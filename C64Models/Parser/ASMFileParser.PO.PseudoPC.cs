﻿using GR.Memory;
using RetroDevStudio.Formats;
using RetroDevStudio.Parser;
using RetroDevStudio.Types;
using System;
using System.Collections.Generic;

namespace RetroDevStudio.Parser
{
  public partial class ASMFileParser : ParserBase
  {
    private ParseLineResult POPseudoPC( Types.ASM.LineInfo info, List<Types.ScopeInfo> Scopes, int lineIndex, List<Types.TokenInfo> lineTokenInfos, int TokenStartIndex, int TokenCount )
    {
      if ( TokenCount == 0 )
      {
        AddError( lineIndex,
                  Types.ErrorCode.E1000_SYNTAX_ERROR,
                  "Expression expected",
                  lineTokenInfos[0].StartPos,
                  lineTokenInfos[lineTokenInfos.Count - 1].EndPos );
        return ParseLineResult.RETURN_NULL;
      }
      if ( lineTokenInfos[TokenStartIndex + TokenCount - 1].Content == "{" )
      {
        // a real PC with bracket
        var scopeInfo = new Types.ScopeInfo( Types.ScopeInfo.ScopeType.PSEUDO_PC );
        scopeInfo.StartIndex = lineIndex;
        scopeInfo.Active = true;

        Scopes.Add( scopeInfo );
        OnScopeAdded( scopeInfo );
        --TokenCount;
      }

      if ( !EvaluateTokens( lineIndex, lineTokenInfos, TokenStartIndex, TokenCount, info.LineCodeMapping, out SymbolInfo pseudoStepPos ) )
      {
        string expressionCheck = TokensToExpression( lineTokenInfos, TokenStartIndex, TokenCount );

        AddError( lineIndex,
                  Types.ErrorCode.E1001_FAILED_TO_EVALUATE_EXPRESSION,
                  "Could not evaluate expression " + TokensToExpression( lineTokenInfos, 1, lineTokenInfos.Count - 1 ),
                  lineTokenInfos[1].StartPos,
                  lineTokenInfos[lineTokenInfos.Count - 1].EndPos + 1 - lineTokenInfos[1].StartPos );
        return ParseLineResult.RETURN_NULL;
      }
      info.PseudoPCOffset = pseudoStepPos.ToInt32();
      return ParseLineResult.OK;
    }



  }
}
