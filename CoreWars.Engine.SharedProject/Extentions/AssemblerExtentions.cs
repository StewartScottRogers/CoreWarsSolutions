using System.Collections.Generic;
using System.Linq;

using CoreWars.Engine.Attributes;
using CoreWars.Engine.Enumerations;

namespace CoreWars.Engine.Extentions {
    internal static class AssemblerExtentions {
        public static (string Name, string Cotent, IEnumerable<(short lineNumber, string line)> Codelines) GetTargetProgram(this (string name, string content) targetProgram)
            => (Name: targetProgram.name, Cotent: targetProgram.content, Codelines: targetProgram.content.ToLines());


        public static IEnumerable<short> AssembleExecutable(this (string Name, string Cotent, IEnumerable<(short lineNumber, string line)> Codelines) program) {

            IEnumerable<(short LineNumber, string LineType, string Label, string Command, string ParameterA, string ParameterB)> parsedCodeLines
                = program.Codelines.ParseCodeLines();

            var assembledOpcodePointers = parsedCodeLines.AssembleOpcodePointers();

            var labeledLineNumbersDictionary = assembledOpcodePointers.CreateLabeledLineNumbersDictionary();
            var labledValuePairDictionary = assembledOpcodePointers.CreateLabledVariableDictionary();

            var mergedDictionaries = labeledLineNumbersDictionary.Concat(labledValuePairDictionary)
                .ToLookup(x => x.Key, x => x.Value)
                .ToDictionary(x => x.Key, g => g.First());

            foreach (var assembledOpcodePointer in assembledOpcodePointers) {
                if ("equ" == assembledOpcodePointer.Command)
                    continue;

                OpcodeTypes opcodeTypes = assembledOpcodePointer.Command.ToOpcodeType();        
                short opcodePointer = assembledOpcodePointer.OpcodePointer;
                (AddressTypes AddressType, short Result) parameterA = assembledOpcodePointer.ParameterA.ToRegister(mergedDictionaries);
                (AddressTypes AddressType, short Result) parameterB = assembledOpcodePointer.ParameterB.ToRegister(mergedDictionaries);




            }


            yield break;
        }



        public static IEnumerable<(short OpcodePointer, short LineNumber, string LineType, string Label, string Command, string ParameterA, string ParameterB)>
            AssembleOpcodePointers(this IEnumerable<(short LineNumber, string LineType, string Label, string Command, string ParameterA, string ParameterB)> parsedCodeLines) {

            short opcodePointer = 0;

            foreach (var parsedCodeLine in parsedCodeLines) {
                if ("equ" == parsedCodeLine.Command)
                    continue;

                var result = (
                                OpcodePointer: (short)opcodePointer,
                                LineNumber: parsedCodeLine.LineNumber,
                                LineType: parsedCodeLine.LineType,
                                Label: parsedCodeLine.Label,

                                Command: parsedCodeLine.Command,
                                ParameterA: parsedCodeLine.ParameterA,
                                ParameterB: parsedCodeLine.ParameterB
                             );


                SymbolAttribute symbolAttribute
                    = result.Command.ToOpcode().ToOpcodeType().GetSymbol();

                opcodePointer++;
                if (symbolAttribute.ParameterRequiredA)
                    opcodePointer++;
                if (symbolAttribute.ParameterRequiredB)
                    opcodePointer++;


                yield return result;
            }



            yield break;
        }

    }
}
