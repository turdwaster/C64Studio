﻿using System;
using System.Collections.Generic;
using System.Text;
using static Tiny64.Opcode;

namespace Tiny64
{
  public partial class Processor
  {
    public static Processor Create6502()
    {
      // 6510 without illegal opcodes
      var  sys = new Processor( "6502" );

      sys.AddOpcode( "adc", 0x6d, 2, AddressingType.ABSOLUTE, 4 );           // ADC $hhll
      sys.AddOpcode( "adc", 0x7d, 2, AddressingType.ABSOLUTE_X, 4, 1 );      // ADC $hhll, X
      sys.AddOpcode( "adc", 0x79, 2, AddressingType.ABSOLUTE_Y, 4, 1 );      // ADC $hhll, Y
      sys.AddOpcode( "adc", 0x65, 1, AddressingType.ZEROPAGE, 3 );           // ADC $ll
      sys.AddOpcode( "adc", 0x75, 1, AddressingType.ZEROPAGE_X, 4 );         // ADC $ll, X
      sys.AddOpcode( "adc", 0x71, 1, AddressingType.ZEROPAGE_INDIRECT_Y, 5, 1 );      // ADC ($ll), Y
      sys.AddOpcode( "adc", 0x61, 1, AddressingType.ZEROPAGE_INDIRECT_X, 6 );         // ADC ($ll,X)
      sys.AddOpcode( "adc", 0x69, 1, AddressingType.IMMEDIATE_ACCU, 2 );          // ADC #$nn
      sys.AddOpcode( "and", 0x2d, 2, AddressingType.ABSOLUTE, 4 );           // AND $hhll
      sys.AddOpcode( "and", 0x3d, 2, AddressingType.ABSOLUTE_X, 4, 1 );      // AND $hhll, X
      sys.AddOpcode( "and", 0x39, 2, AddressingType.ABSOLUTE_Y, 4, 1 );      // AND $hhll, Y
      sys.AddOpcode( "and", 0x25, 1, AddressingType.ZEROPAGE, 3 );           // AND $ll
      sys.AddOpcode( "and", 0x35, 1, AddressingType.ZEROPAGE_X, 4 );         // AND $ll, X
      sys.AddOpcode( "and", 0x31, 1, AddressingType.ZEROPAGE_INDIRECT_Y, 5, 1 );      // AND ($ll), Y
      sys.AddOpcode( "and", 0x21, 1, AddressingType.ZEROPAGE_INDIRECT_X, 6 );         // AND ($ll,X)
      sys.AddOpcode( "and", 0x29, 1, AddressingType.IMMEDIATE_ACCU, 2 );          // AND #$nn
      sys.AddOpcode( "asl", 0x0a, 0, AddressingType.IMPLICIT, 2 );           // ASL
      sys.AddOpcode( "asl", 0x0e, 2, AddressingType.ABSOLUTE, 6 );           // ASL $hhll
      sys.AddOpcode( "asl", 0x1e, 2, AddressingType.ABSOLUTE_X, 7 );         // ASL $hhll, X
      sys.AddOpcode( "asl", 0x06, 1, AddressingType.ZEROPAGE, 5 );           // ASL $ll
      sys.AddOpcode( "asl", 0x16, 1, AddressingType.ZEROPAGE_X, 6 );         // ASL $ll, X
      sys.AddOpcode( "bcc", 0x90, 1, AddressingType.RELATIVE, 2, 0, 1, 2 );  // BCC $hhll
      sys.AddOpcode( "bcs", 0xB0, 1, AddressingType.RELATIVE, 2, 0, 1, 2 );  // BCS $hhll
      sys.AddOpcode( "beq", 0xF0, 1, AddressingType.RELATIVE, 2, 0, 1, 2 );  // BEQ $hhll
      sys.AddOpcode( "bit", 0x2c, 2, AddressingType.ABSOLUTE, 4 );           // BIT $hhll
      sys.AddOpcode( "bit", 0x24, 1, AddressingType.ZEROPAGE, 3 );           // BIT $ll
      sys.AddOpcode( "bmi", 0x30, 1, AddressingType.RELATIVE, 2, 0, 1, 2 );  // BMI $hhll
      sys.AddOpcode( "bne", 0xD0, 1, AddressingType.RELATIVE, 2, 0, 1, 2 );  // BNE $hhll
      sys.AddOpcode( "bpl", 0x10, 1, AddressingType.RELATIVE, 2, 0, 1, 2 );  // BPL $hhll
      sys.AddOpcode( "brk", 0x00, 0, AddressingType.IMPLICIT, 7 );           // BRK
      sys.AddOpcode( "bvc", 0x50, 1, AddressingType.RELATIVE, 2, 0, 1, 2 );  // BVC $hhll
      sys.AddOpcode( "bvs", 0x70, 1, AddressingType.RELATIVE, 2, 0, 1, 2 );  // BVS $hhll
      sys.AddOpcode( "clc", 0x18, 0, AddressingType.IMPLICIT, 2 );           // CLC
      sys.AddOpcode( "cld", 0xD8, 0, AddressingType.IMPLICIT, 2 );           // CLD
      sys.AddOpcode( "cli", 0x58, 0, AddressingType.IMPLICIT, 2 );           // CLI
      sys.AddOpcode( "clv", 0xB8, 0, AddressingType.IMPLICIT, 2 );           // CLV
      sys.AddOpcode( "cmp", 0xCD, 2, AddressingType.ABSOLUTE, 4 );           // CMP $hhll
      sys.AddOpcode( "cmp", 0xDD, 2, AddressingType.ABSOLUTE_X, 4, 1 );      // CMP $hhll, X
      sys.AddOpcode( "cmp", 0xD9, 2, AddressingType.ABSOLUTE_Y, 4, 1 );      // CMP $hhll, Y
      sys.AddOpcode( "cmp", 0xC5, 1, AddressingType.ZEROPAGE, 3 );           // CMP $ll
      sys.AddOpcode( "cmp", 0xD5, 1, AddressingType.ZEROPAGE_X, 4 );         // CMP $ll, X
      sys.AddOpcode( "cmp", 0xD1, 1, AddressingType.ZEROPAGE_INDIRECT_Y, 5, 1 );      // CMP ($ll), Y
      sys.AddOpcode( "cmp", 0xC1, 1, AddressingType.ZEROPAGE_INDIRECT_X, 6 );         // CMP ($ll,X)
      sys.AddOpcode( "cmp", 0xC9, 1, AddressingType.IMMEDIATE_ACCU, 2 );          // CMP #$nn
      sys.AddOpcode( "cpx", 0xEC, 2, AddressingType.ABSOLUTE, 4 );           // CPX $hhll
      sys.AddOpcode( "cpx", 0xE4, 1, AddressingType.ZEROPAGE, 3 );           // CPX $ll
      sys.AddOpcode( "cpx", 0xE0, 1, AddressingType.IMMEDIATE_REGISTER, 2 );          // CPX #$nn
      sys.AddOpcode( "cpy", 0xCC, 2, AddressingType.ABSOLUTE, 4 );           // CPY $hhll
      sys.AddOpcode( "cpy", 0xC4, 1, AddressingType.ZEROPAGE, 3 );           // CPY $ll
      sys.AddOpcode( "cpy", 0xC0, 1, AddressingType.IMMEDIATE_REGISTER, 2 );          // CPY #$nn
      sys.AddOpcode( "dec", 0xCE, 2, AddressingType.ABSOLUTE, 6 );           // DEC $hhll
      sys.AddOpcode( "dec", 0xDE, 2, AddressingType.ABSOLUTE_X, 7 );         // DEC $hhll, X
      sys.AddOpcode( "dec", 0xC6, 1, AddressingType.ZEROPAGE, 5 );           // DEC $ll
      sys.AddOpcode( "dec", 0xD6, 1, AddressingType.ZEROPAGE_X, 6 );         // DEC $ll, X
      sys.AddOpcode( "dex", 0xCA, 0, AddressingType.IMPLICIT, 2 );           // DEX
      sys.AddOpcode( "dey", 0x88, 0, AddressingType.IMPLICIT, 2 );           // DEY
      sys.AddOpcode( "eor", 0x4D, 2, AddressingType.ABSOLUTE, 4 );           // EOR $hhll
      sys.AddOpcode( "eor", 0x5D, 2, AddressingType.ABSOLUTE_X, 4, 1 );      // EOR $hhll, X
      sys.AddOpcode( "eor", 0x59, 2, AddressingType.ABSOLUTE_Y, 4, 1 );      // EOR $hhll, Y
      sys.AddOpcode( "eor", 0x45, 1, AddressingType.ZEROPAGE, 3 );           // EOR $ll
      sys.AddOpcode( "eor", 0x55, 1, AddressingType.ZEROPAGE_X, 4 );         // EOR $ll, X
      sys.AddOpcode( "eor", 0x51, 1, AddressingType.ZEROPAGE_INDIRECT_Y, 5, 1 );      // EOR ($ll), Y
      sys.AddOpcode( "eor", 0x41, 1, AddressingType.ZEROPAGE_INDIRECT_X, 6 );         // EOR ($ll,X)
      sys.AddOpcode( "eor", 0x49, 1, AddressingType.IMMEDIATE_ACCU, 2 );          // EOR #$nn
      sys.AddOpcode( "inc", 0xEE, 2, AddressingType.ABSOLUTE, 6 );           // INC $hhll
      sys.AddOpcode( "inc", 0xFE, 2, AddressingType.ABSOLUTE_X, 7 );         // INC $hhll, X
      sys.AddOpcode( "inc", 0xE6, 1, AddressingType.ZEROPAGE, 5 );           // INC $ll
      sys.AddOpcode( "inc", 0xF6, 1, AddressingType.ZEROPAGE_X, 6 );         // INC $ll, X
      sys.AddOpcode( "inx", 0xE8, 0, AddressingType.IMPLICIT, 2 );           // INX
      sys.AddOpcode( "iny", 0xC8, 0, AddressingType.IMPLICIT, 2 );           // INY
      sys.AddOpcode( "jmp", 0x4C, 2, AddressingType.ABSOLUTE, 3 );           // JMP $hhll
      sys.AddOpcode( "jmp", 0x6C, 2, AddressingType.INDIRECT, 5 );           // JMP ($hhll)
      sys.AddOpcode( "jsr", 0x20, 2, AddressingType.ABSOLUTE, 6 );           // JSR $hhll
      sys.AddOpcode( "lda", 0xAD, 2, AddressingType.ABSOLUTE, 4 );           // LDA $hhll
      sys.AddOpcode( "lda", 0xBD, 2, AddressingType.ABSOLUTE_X, 4, 1 );      // LDA $hhll, X
      sys.AddOpcode( "lda", 0xB9, 2, AddressingType.ABSOLUTE_Y, 4, 1 );      // LDA $hhll, Y
      sys.AddOpcode( "lda", 0xA5, 1, AddressingType.ZEROPAGE, 3 );           // LDA $ll
      sys.AddOpcode( "lda", 0xB5, 1, AddressingType.ZEROPAGE_X, 4 );         // LDA $ll, X
      sys.AddOpcode( "lda", 0xB1, 1, AddressingType.ZEROPAGE_INDIRECT_Y, 5, 1 );      // LDA ($ll), Y
      sys.AddOpcode( "lda", 0xA1, 1, AddressingType.ZEROPAGE_INDIRECT_X, 6 );         // LDA ($ll,X)
      sys.AddOpcode( "lda", 0xA9, 1, AddressingType.IMMEDIATE_ACCU, 2 );          // LDA #$nn
      sys.AddOpcode( "ldx", 0xAE, 2, AddressingType.ABSOLUTE, 4 );           // LDX $hhll
      sys.AddOpcode( "ldx", 0xBE, 2, AddressingType.ABSOLUTE_Y, 4, 1 );      // LDX $hhll, Y
      sys.AddOpcode( "ldx", 0xA6, 1, AddressingType.ZEROPAGE, 3 );           // LDX $ll
      sys.AddOpcode( "ldx", 0xB6, 1, AddressingType.ZEROPAGE_Y, 4 );         // LDX $ll, Y
      sys.AddOpcode( "ldx", 0xA2, 1, AddressingType.IMMEDIATE_REGISTER, 2 );          // LDX #$nn
      sys.AddOpcode( "ldy", 0xAC, 2, AddressingType.ABSOLUTE, 4 );           // LDY $hhll
      sys.AddOpcode( "ldy", 0xBC, 2, AddressingType.ABSOLUTE_X, 4, 1 );      // LDY $hhll, X
      sys.AddOpcode( "ldy", 0xA4, 1, AddressingType.ZEROPAGE, 3 );           // LDY $ll
      sys.AddOpcode( "ldy", 0xB4, 1, AddressingType.ZEROPAGE_X, 4 );         // LDY $ll, X
      sys.AddOpcode( "ldy", 0xA0, 1, AddressingType.IMMEDIATE_REGISTER, 2 );          // LDY #$nn
      sys.AddOpcode( "lsr", 0x4A, 0, AddressingType.IMPLICIT, 2 );           // LSR
      sys.AddOpcode( "lsr", 0x4E, 2, AddressingType.ABSOLUTE, 6 );           // LSR $hhll
      sys.AddOpcode( "lsr", 0x5E, 2, AddressingType.ABSOLUTE_X, 7 );         // LSR $hhll, X
      sys.AddOpcode( "lsr", 0x46, 1, AddressingType.ZEROPAGE, 5 );           // LSR $ll
      sys.AddOpcode( "lsr", 0x56, 1, AddressingType.ZEROPAGE_X, 6 );         // LSR $ll, X
      sys.AddOpcode( "nop", 0xEA, 0, AddressingType.IMPLICIT, 2 );           // NOP
      sys.AddOpcode( "ora", 0x0D, 2, AddressingType.ABSOLUTE, 4 );           // ORA $hhll
      sys.AddOpcode( "ora", 0x1D, 2, AddressingType.ABSOLUTE_X, 4, 1 );      // ORA $hhll, X
      sys.AddOpcode( "ora", 0x19, 2, AddressingType.ABSOLUTE_Y, 4, 1 );      // ORA $hhll, Y
      sys.AddOpcode( "ora", 0x05, 1, AddressingType.ZEROPAGE, 3 );           // ORA $ll
      sys.AddOpcode( "ora", 0x15, 1, AddressingType.ZEROPAGE_X, 4 );         // ORA $ll, X
      sys.AddOpcode( "ora", 0x11, 1, AddressingType.ZEROPAGE_INDIRECT_Y, 5, 1 );      // ORA ($ll), Y
      sys.AddOpcode( "ora", 0x01, 1, AddressingType.ZEROPAGE_INDIRECT_X, 6 );         // ORA ($ll,X)
      sys.AddOpcode( "ora", 0x09, 1, AddressingType.IMMEDIATE_ACCU, 2 );          // ORA #$nn
      sys.AddOpcode( "pha", 0x48, 0, AddressingType.IMPLICIT, 3 );           // PHA
      sys.AddOpcode( "php", 0x08, 0, AddressingType.IMPLICIT, 3 );           // PHP
      sys.AddOpcode( "pla", 0x68, 0, AddressingType.IMPLICIT, 4 );           // PLA
      sys.AddOpcode( "plp", 0x28, 0, AddressingType.IMPLICIT, 4 );           // PLP
      sys.AddOpcode( "rol", 0x2A, 0, AddressingType.IMPLICIT, 2 );           // ROL
      sys.AddOpcode( "rol", 0x2E, 2, AddressingType.ABSOLUTE, 6 );           // ROL $hhll
      sys.AddOpcode( "rol", 0x3E, 2, AddressingType.ABSOLUTE_X, 7 );         // ROL $hhll, X
      sys.AddOpcode( "rol", 0x26, 1, AddressingType.ZEROPAGE, 5 );           // ROL $ll
      sys.AddOpcode( "rol", 0x36, 1, AddressingType.ZEROPAGE_X, 6 );         // ROL $ll, X
      sys.AddOpcode( "ror", 0x6A, 0, AddressingType.IMPLICIT, 2 );           // ROR
      sys.AddOpcode( "ror", 0x6E, 2, AddressingType.ABSOLUTE, 6 );           // ROR $hhll
      sys.AddOpcode( "ror", 0x7E, 2, AddressingType.ABSOLUTE_X, 7 );         // ROR $hhll, X
      sys.AddOpcode( "ror", 0x66, 1, AddressingType.ZEROPAGE, 5 );           // ROR $ll
      sys.AddOpcode( "ror", 0x76, 1, AddressingType.ZEROPAGE_X, 6 );         // ROR $ll, X
      sys.AddOpcode( "rti", 0x40, 0, AddressingType.IMPLICIT, 6 );           // RTI
      sys.AddOpcode( "rts", 0x60, 0, AddressingType.IMPLICIT, 6 );           // RTS
      sys.AddOpcode( "sbc", 0xED, 2, AddressingType.ABSOLUTE, 4 );           // SBC $hhll
      sys.AddOpcode( "sbc", 0xFD, 2, AddressingType.ABSOLUTE_X, 4, 1 );      // SBC $hhll, X
      sys.AddOpcode( "sbc", 0xF9, 2, AddressingType.ABSOLUTE_Y, 4, 1 );      // SBC $hhll, Y
      sys.AddOpcode( "sbc", 0xE5, 1, AddressingType.ZEROPAGE, 3 );           // SBC $ll
      sys.AddOpcode( "sbc", 0xF5, 1, AddressingType.ZEROPAGE_X, 4 );         // SBC $ll, X
      sys.AddOpcode( "sbc", 0xF1, 1, AddressingType.ZEROPAGE_INDIRECT_Y, 5, 1 );      // SBC ($ll), Y
      sys.AddOpcode( "sbc", 0xE1, 1, AddressingType.ZEROPAGE_INDIRECT_X, 6 );         // SBC ($ll,X)
      sys.AddOpcode( "sbc", 0xE9, 1, AddressingType.IMMEDIATE_ACCU, 2 );          // SBC #$nn
      sys.AddOpcode( "sec", 0x38, 0, AddressingType.IMPLICIT, 2 );           // SEC
      sys.AddOpcode( "sed", 0xF8, 0, AddressingType.IMPLICIT, 2 );           // SED
      sys.AddOpcode( "sei", 0x78, 0, AddressingType.IMPLICIT, 2 );           // SEI
      sys.AddOpcode( "sta", 0x8D, 2, AddressingType.ABSOLUTE, 4 );           // STA $hhll
      sys.AddOpcode( "sta", 0x9D, 2, AddressingType.ABSOLUTE_X, 5 );         // STA $hhll, X
      sys.AddOpcode( "sta", 0x99, 2, AddressingType.ABSOLUTE_Y, 5 );         // STA $hhll, Y
      sys.AddOpcode( "sta", 0x85, 1, AddressingType.ZEROPAGE, 3 );           // STA $ll
      sys.AddOpcode( "sta", 0x95, 1, AddressingType.ZEROPAGE_X, 4 );         // STA $ll, X
      sys.AddOpcode( "sta", 0x91, 1, AddressingType.ZEROPAGE_INDIRECT_Y, 6 );         // STA ($ll), Y
      sys.AddOpcode( "sta", 0x81, 1, AddressingType.ZEROPAGE_INDIRECT_X, 6 );         // STA ($ll,X)
      sys.AddOpcode( "stx", 0x8E, 2, AddressingType.ABSOLUTE, 4 );           // STX $hhll
      sys.AddOpcode( "stx", 0x86, 1, AddressingType.ZEROPAGE, 3 );           // STX $ll
      sys.AddOpcode( "stx", 0x96, 1, AddressingType.ZEROPAGE_Y, 4 );         // STX $ll, Y
      sys.AddOpcode( "sty", 0x8C, 2, AddressingType.ABSOLUTE, 4 );           // STY $hhll
      sys.AddOpcode( "sty", 0x84, 1, AddressingType.ZEROPAGE, 3 );           // STY $ll
      sys.AddOpcode( "sty", 0x94, 1, AddressingType.ZEROPAGE_X, 4 );         // STY $ll, X
      sys.AddOpcode( "tax", 0xAA, 0, AddressingType.IMPLICIT, 2 );           // TAX
      sys.AddOpcode( "tay", 0xA8, 0, AddressingType.IMPLICIT, 2 );           // TAY
      sys.AddOpcode( "tsx", 0xBA, 0, AddressingType.IMPLICIT, 2 );           // TSX
      sys.AddOpcode( "txa", 0x8A, 0, AddressingType.IMPLICIT, 2 );           // TXA
      sys.AddOpcode( "txs", 0x9A, 0, AddressingType.IMPLICIT, 2 );           // TXS
      sys.AddOpcode( "tya", 0x98, 0, AddressingType.IMPLICIT, 2 );           // TYA

      sys.AddOpcode( "jam", 0x02, 0, AddressingType.IMPLICIT, 0 );           // JAM
      sys.AddOpcodeForDisassembly( "jam", 0x12, 0, AddressingType.IMPLICIT );      // JAM
      sys.AddOpcodeForDisassembly( "jam", 0x22, 0, AddressingType.IMPLICIT );      // JAM
      sys.AddOpcodeForDisassembly( "jam", 0x32, 0, AddressingType.IMPLICIT );      // JAM
      sys.AddOpcodeForDisassembly( "jam", 0x42, 0, AddressingType.IMPLICIT );      // JAM
      sys.AddOpcodeForDisassembly( "jam", 0x52, 0, AddressingType.IMPLICIT );      // JAM
      sys.AddOpcodeForDisassembly( "jam", 0x62, 0, AddressingType.IMPLICIT );      // JAM
      sys.AddOpcodeForDisassembly( "jam", 0x72, 0, AddressingType.IMPLICIT );      // JAM
      sys.AddOpcodeForDisassembly( "jam", 0x92, 0, AddressingType.IMPLICIT );      // JAM
      sys.AddOpcodeForDisassembly( "jam", 0xb2, 0, AddressingType.IMPLICIT );      // JAM
      sys.AddOpcodeForDisassembly( "jam", 0xd2, 0, AddressingType.IMPLICIT );      // JAM
      sys.AddOpcodeForDisassembly( "jam", 0xf2, 0, AddressingType.IMPLICIT );      // JAM

      //sys.AddOpcodeForDisassembly( "nop", 0x04, 1, AddressingType.ZEROPAGE );      // NOP $zp
      sys.AddOpcode( "nop", 0x04, 1, AddressingType.ZEROPAGE, 3 );      // NOP $zp
      //sys.AddOpcodeForDisassembly( "nop", 0x0C, 2, AddressingType.ABSOLUTE );      // NOP $abcd
      sys.AddOpcode( "nop", 0x0C, 2, AddressingType.ABSOLUTE, 4 );      // NOP $abcd
      //sys.AddOpcodeForDisassembly( "nop", 0x14, 1, AddressingType.ZEROPAGE_X );    // NOP $zp,x
      sys.AddOpcode( "nop", 0x14, 1, AddressingType.ZEROPAGE_X, 4 );    // NOP $zp,x
      sys.AddOpcodeForDisassembly( "nop", 0x1A, 0, AddressingType.IMPLICIT );      // NOP
      //sys.AddOpcodeForDisassembly( "nop", 0x1C, 2, AddressingType.ABSOLUTE_X );    // NOP $abcd,x
      sys.AddOpcode( "nop", 0x1C, 2, AddressingType.ABSOLUTE_X, 4, 1 );    // NOP $abcd,x
      sys.AddOpcodeForDisassembly( "nop", 0x34, 1, AddressingType.ZEROPAGE_X );    // NOP $zp,x
      sys.AddOpcodeForDisassembly( "nop", 0x3A, 0, AddressingType.IMPLICIT );      // NOP
      sys.AddOpcodeForDisassembly( "nop", 0x3C, 2, AddressingType.ABSOLUTE_X );    // NOP $abcd,x
      sys.AddOpcodeForDisassembly( "nop", 0x44, 1, AddressingType.ZEROPAGE );      // NOP $zp
      sys.AddOpcodeForDisassembly( "nop", 0x54, 1, AddressingType.ZEROPAGE_X );    // NOP $zp,x
      sys.AddOpcodeForDisassembly( "nop", 0x5A, 0, AddressingType.IMPLICIT );      // NOP
      sys.AddOpcodeForDisassembly( "nop", 0x5C, 2, AddressingType.ABSOLUTE_X );    // NOP $abcd,x
      sys.AddOpcodeForDisassembly( "nop", 0x64, 1, AddressingType.ZEROPAGE );      // NOP $zp
      sys.AddOpcodeForDisassembly( "nop", 0x74, 1, AddressingType.ZEROPAGE_X );    // NOP $zp,x
      sys.AddOpcodeForDisassembly( "nop", 0x7A, 0, AddressingType.IMPLICIT );      // NOP
      sys.AddOpcodeForDisassembly( "nop", 0x7C, 2, AddressingType.ABSOLUTE_X );    // NOP $abcd,x
      //sys.AddOpcodeForDisassembly( "nop", 0x80, 1, AddressingType.IMMEDIATE );        // NOP #xx
      sys.AddOpcode( "nop", 0x80, 1, AddressingType.IMMEDIATE_ACCU, 2 );        // NOP #xx
      sys.AddOpcodeForDisassembly( "nop", 0x82, 1, AddressingType.IMMEDIATE_ACCU );        // NOP #xx
      sys.AddOpcodeForDisassembly( "nop", 0x89, 1, AddressingType.IMMEDIATE_ACCU );        // NOP #xx
      sys.AddOpcodeForDisassembly( "nop", 0xC2, 1, AddressingType.IMMEDIATE_ACCU );        // NOP #xx
      sys.AddOpcodeForDisassembly( "nop", 0xD4, 1, AddressingType.ZEROPAGE_X );    // NOP $zp,x
      sys.AddOpcodeForDisassembly( "nop", 0xDA, 0, AddressingType.IMPLICIT );      // NOP
      sys.AddOpcodeForDisassembly( "nop", 0xDC, 2, AddressingType.ABSOLUTE_X );    // NOP $abcd,x
      sys.AddOpcodeForDisassembly( "nop", 0xE2, 1, AddressingType.IMMEDIATE_ACCU );        // NOP #xx
      sys.AddOpcodeForDisassembly( "nop", 0xF4, 1, AddressingType.ZEROPAGE_X );    // NOP $zp,x
      sys.AddOpcodeForDisassembly( "nop", 0xFA, 0, AddressingType.IMPLICIT );      // NOP
      sys.AddOpcodeForDisassembly( "nop", 0xFC, 2, AddressingType.ABSOLUTE_X );    // NOP $abcd,x

      return sys;
    }

  }
}
