﻿namespace Squalr.Engine.Architecture.Disassemblers
{
    using System;

    /// <summary>
    /// Interface defining a disassembler.
    /// </summary>
    public interface IDisassembler
    {
        /// <summary>
        /// Disassemble the specified assembly code.
        /// </summary>
        /// <param name="bytes">The raw bytes.</param>
        /// <param name="isProcess32Bit">Whether or not the assembly is in the context of a 32 bit program.</param>
        /// <param name="baseAddress">The address where the code is rebased.</param>
        /// <returns>A string containing the assembly.</returns>
        Instruction[] Disassemble(Byte[] bytes, Boolean isProcess32Bit, UInt64 baseAddress);
    }
    //// End class
}
//// End namespace