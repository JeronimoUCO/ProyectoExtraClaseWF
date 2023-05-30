using ProyectoExtraClaseWF.DataCache;
using ProyectoExtraClaseWF.ErrorManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoExtraClaseWF.LexicalAnalyzer
{
    public class LexicalAnalysis
    {
        private readonly static LexicalAnalysis INSTANCE = new LexicalAnalysis();
        private int CurrentState;
        private string Lexeme;
        private bool Continue;
        private LexicalComponent Component;

        public static void Initialize()
        {
            Scanner.Initialize();
        }

        private static void ReturnAndBack(Category category)
        {

        }
        private static void Return(Category category)
        {

        }
        private static void Restart()
        {
            INSTANCE.CurrentState = 0;
            INSTANCE.Lexeme = "";
            INSTANCE.Continue = true;
        }

        private static void Concatenate()
        {
            INSTANCE.Lexeme = INSTANCE.Lexeme + Scanner.GetCurrentCharacter();
        }

        private static void Concanate(string character)
        {
            INSTANCE.Lexeme = INSTANCE.Lexeme + character;
        }

        private static void DevourBlankCharacter()
        {
            Scanner.ReadNextCharacter();

            while (" ".Equals(Scanner.GetCurrentCharacter()))
            {
                Scanner.ReadNextCharacter();
            }
        }

        private static void LoadNewLine()
        {

        }

        private static void ThrowErrorAndBack(String error) { }
        private static void ThrowError(String error) { }
        public static LexicalComponent Analyze()
        {
            Restart();

            while (INSTANCE.Continue)
            {
                if (INSTANCE.CurrentState == 0)
                {
                    ProcessState0();
                }
                if (INSTANCE.CurrentState == 1)
                {
                    ProcessState1();
                }
                if (INSTANCE.CurrentState == 2)
                {
                    ProcessState2();
                }
                if (INSTANCE.CurrentState == 3)
                {
                    ProcessState3();
                }
                if (INSTANCE.CurrentState == 4)
                {
                    ProcessState4();
                }
                if (INSTANCE.CurrentState == 5)
                {
                    ProcessState5();
                }
                if (INSTANCE.CurrentState == 6)
                {
                    ProcessState6();
                }
                if (INSTANCE.CurrentState == 7)
                {
                    ProcessState7();
                }
                if (INSTANCE.CurrentState == 8)
                {
                    ProcessState8();
                }
                if (INSTANCE.CurrentState == 9)
                {
                    ProcessState9();
                }
                if (INSTANCE.CurrentState == 10)
                {
                    ProcessState10();
                }
                if (INSTANCE.CurrentState == 11)
                {
                    ProcessState11();
                }
                if (INSTANCE.CurrentState == 12)
                {
                    ProcessState12();
                }
                if (INSTANCE.CurrentState == 14)
                {
                    ProcessState14();
                }
                if (INSTANCE.CurrentState == 16)
                {
                    ProcessState16();
                }
                if (INSTANCE.CurrentState == 17)
                {
                    ProcessState17();
                }
                if (INSTANCE.CurrentState == 18)
                {
                    ProcessState18();
                }
                if (INSTANCE.CurrentState == 19)
                {
                    ProcessState19();
                }
                if (INSTANCE.CurrentState == 20)
                {
                    ProcessState20();
                }
                if (INSTANCE.CurrentState == 21)
                {
                    ProcessState21();
                }
                if (INSTANCE.CurrentState == 22)
                {
                    ProcessState22();
                }
                if (INSTANCE.CurrentState == 24)
                {
                    ProcessState24();
                }
                if (INSTANCE.CurrentState == 25)
                {
                    ProcessState25();
                }
                if (INSTANCE.CurrentState == 26)
                {
                    ProcessState26();
                }
                if (INSTANCE.CurrentState == 27)
                {
                    ProcessState27();
                }
                if (INSTANCE.CurrentState == 28)
                {
                    ProcessState28();
                }
                if (INSTANCE.CurrentState == 29)
                {
                    ProcessState29();
                }
                if (INSTANCE.CurrentState == 31)
                {
                    ProcessState31();
                }
                if (INSTANCE.CurrentState == 32)
                {
                    ProcessState32();
                }
                if (INSTANCE.CurrentState == 33)
                {
                    ProcessState33();
                }
                if (INSTANCE.CurrentState == 34)
                {
                    ProcessState34();
                }
                if (INSTANCE.CurrentState == 35)
                {
                    ProcessState35();
                }
                if (INSTANCE.CurrentState == 36)
                {
                    ProcessState36();
                }
                if (INSTANCE.CurrentState == 37)
                {
                    ProcessState37();
                }
                if (INSTANCE.CurrentState == 38)
                {
                    ProcessState38();
                }
                if (INSTANCE.CurrentState == 39)
                {
                    ProcessState39();
                }
                if (INSTANCE.CurrentState == 40)
                {
                    ProcessState40();
                }
                if (INSTANCE.CurrentState == 41)
                {
                    ProcessState41();
                }
                if (INSTANCE.CurrentState == 42)
                {
                    ProcessState42();
                }
                if (INSTANCE.CurrentState == 43)
                {
                    ProcessState43();
                }
                if (INSTANCE.CurrentState == 44)
                {
                    ProcessState44();
                }
                if (INSTANCE.CurrentState == 45)
                {
                    ProcessState45();
                }
                if (INSTANCE.CurrentState == 46)
                {
                    ProcessState46();
                }
                if (INSTANCE.CurrentState == 47)
                {
                    ProcessState47();
                }
                if (INSTANCE.CurrentState == 48)
                {
                    ProcessState48();
                }
                if (INSTANCE.CurrentState == 49)
                {
                    ProcessState49();
                }
                if (INSTANCE.CurrentState == 50)
                {
                    ProcessState50();
                }
                if (INSTANCE.CurrentState == 51)
                {
                    ProcessState51();
                }
                if (INSTANCE.CurrentState == 52)
                {
                    ProcessState52();
                }
                if (INSTANCE.CurrentState == 53)
                {
                    ProcessState53();
                }
                if (INSTANCE.CurrentState == 54)
                {
                    ProcessState54();
                }
                if (INSTANCE.CurrentState == 55)
                {
                    ProcessState55();
                }
                if (INSTANCE.CurrentState == 56)
                {
                    ProcessState56();
                }
                if (INSTANCE.CurrentState == 57)
                {
                    ProcessState57();
                }
                if (INSTANCE.CurrentState == 58)
                {
                    ProcessState58();
                }

                if (INSTANCE.CurrentState == 59)
                {
                    ProcessState59();
                }
                if (INSTANCE.CurrentState == 60)
                {
                    ProcessState60();
                }
                if (INSTANCE.CurrentState == 62)
                {
                    ProcessState62();
                }

                if (INSTANCE.CurrentState == 64)
                {
                    ProcessState64();
                }

                if (INSTANCE.CurrentState == 66)
                {
                    ProcessState66();
                }
                if (INSTANCE.CurrentState == 67)
                {
                    ProcessState67();
                }
                if (INSTANCE.CurrentState == 68)
                {
                    ProcessState68();
                }
                if (INSTANCE.CurrentState == 69)
                {
                    ProcessState69();
                }
                if (INSTANCE.CurrentState == 70)
                {
                    ProcessState70();
                }
                if (INSTANCE.CurrentState == 71)
                {
                    ProcessState71();
                }
                if (INSTANCE.CurrentState == 72)
                {
                    ProcessState72();
                }
                if (INSTANCE.CurrentState == 73)
                {
                    ProcessState73();
                }
                if (INSTANCE.CurrentState == 74)
                {
                    ProcessState74();
                }
                if (INSTANCE.CurrentState == 75)
                {
                    ProcessState75();
                }
                if (INSTANCE.CurrentState == 76)
                {
                    ProcessState76();
                }
                if (INSTANCE.CurrentState == 77)
                {
                    ProcessState77();
                }
                if (INSTANCE.CurrentState == 78)
                {
                    ProcessState78();
                }
                if (INSTANCE.CurrentState == 79)
                {
                    ProcessState79();
                }
                if (INSTANCE.CurrentState == 80)
                {
                    ProcessState80();
                }
                if (INSTANCE.CurrentState == 81)
                {
                    ProcessState81();
                }
                if (INSTANCE.CurrentState == 82)
                {
                    ProcessState82();
                }
                if (INSTANCE.CurrentState == 83)
                {
                    ProcessState83();
                }
                if (INSTANCE.CurrentState == 84)
                {
                    ProcessState84();
                }
                if (INSTANCE.CurrentState == 85)
                {
                    ProcessState85();
                }
                if (INSTANCE.CurrentState == 86)
                {
                    ProcessState86();
                }
                if (INSTANCE.CurrentState == 87)
                {
                    ProcessState87();
                }
                if (INSTANCE.CurrentState == 88)
                {
                    ProcessState88();
                }
                if (INSTANCE.CurrentState == 89)
                {
                    ProcessState89();
                }
            }
            return INSTANCE.Component;
        }
        private static void ProcessState0()
        {
            DevourBlankCharacter();
            if (IsSlash())
            {
                Concatenate();
                INSTANCE.CurrentState = 1;
            }
            else if (IsO())
            {
                Concatenate();
                INSTANCE.CurrentState = 1;
            }
            else if (IsS())
            {
                Concatenate();
                INSTANCE.CurrentState = 33;
            }
            else if (IsMinusc() || IsA() || IsB() || IsC() || IsD() || IsE() || IsG() || IsH() || IsJ() || IsK() || IsM() || IsN() || IsP()
                || IsQ() || IsR() || IsT() || IsU() || IsV() || IsW() || IsX() || IsZ())
            {
                Concatenate();
                INSTANCE.CurrentState = 31;
            }
            else if (IsI())
            {
                Concatenate();
                INSTANCE.CurrentState = 24;
            }
            else if (IsQuotationMark())
            {
                Concatenate();
                INSTANCE.CurrentState = 56;
            }
            else if (IsY())
            {
                Concatenate();
                INSTANCE.CurrentState = 12;
            }
            else if (IsOpenBrace())
            {
                Concatenate();
                INSTANCE.CurrentState = 62;
            }
            else if (IsF())
            {
                Concatenate();
                INSTANCE.CurrentState = 10;
            }
            else if (IsL())
            {
                Concatenate();
                INSTANCE.CurrentState = 58;
            }
            else if (IsAddition())
            {
                Concatenate();
                INSTANCE.CurrentState = 44;
            }
            else if (IsMultiplication())
            {
                Concatenate();
                INSTANCE.CurrentState = 42;
            }
            else if (IsEqual())
            {
                Concatenate();
                INSTANCE.CurrentState = 69;
            }
            else if (IsCloseBrace())
            {
                Concatenate();
                INSTANCE.CurrentState = 64;
            }
            else if (IsMinus())
            {
                Concatenate();
                INSTANCE.CurrentState = 43;
            }
            else if (IsLessThan())
            {
                Concatenate();
                INSTANCE.CurrentState = 46;
            }
            else if (IsFL())
            {
                INSTANCE.CurrentState = 55;
            }
            else if (IsDigit())
            {
                Concatenate();
                INSTANCE.CurrentState = 40;
            }
            else if (IsGreaterThan())
            {
                Concatenate();
                INSTANCE.CurrentState = 47;
            }
            else if (IsRightParenthesis())
            {
                Concatenate();
                INSTANCE.CurrentState = 6;
            }
            else if (IsLeftParenthesis())
            {
                Concatenate();
                INSTANCE.CurrentState = 5;
            }
            else
            {
                INSTANCE.CurrentState = 11;
            }

        }

        private static void ProcessState1()
        {
            if (IsSlash())
            {
                Concatenate();
                INSTANCE.CurrentState = 2;
            }
            else if (IsMultiplication())
            {
                Concatenate();
                INSTANCE.CurrentState = 3;
            }
            else
            {
                INSTANCE.CurrentState = 41;
            }
        }

        private static void ProcessState2()
        {
            if (IsFL())
            {
                INSTANCE.CurrentState = 55;
            }
            else
            {
                INSTANCE.CurrentState = 2;
            }
        }

        private static void ProcessState3()
        {
            if (IsFL())
            {
                INSTANCE.CurrentState = 68;
            }
            else if (IsMultiplication())
            {
                INSTANCE.CurrentState = 4;
            }
            else
            {
                INSTANCE.CurrentState = 3;
            }
        }

        private static void ProcessState4()
        {
            if (IsSlash())
            {
                INSTANCE.CurrentState = 66;
            }
            else if (IsMultiplication())
            {
                INSTANCE.CurrentState = 4;
            }
        }

        private static void ProcessState5()
        {
            CreateComponentReturningIndex(Category.PARENTESIS_QUE_ABRE, ComponentType.NORMAL);
        }

        private static void ProcessState6()
        {
            CreateComponentReturningIndex(Category.PARENTESIS_QUE_CIERRA, ComponentType.NORMAL);
        }

        private static void ProcessState7()
        {
            CreateComponentWithouReturnIndex(Category.PALABRA_RESERVADA_FIN, ComponentType.NORMAL);//RETORNAR PALABRA_RESERVADA_FINSI DE ARCHIVO
        }

        private static void ProcessState8()
        {
            CreateComponentWithouReturnIndex(Category.PALABRA_RESERVADA_FINSI, ComponentType.NORMAL);//RETORNAR PALABRA_RESERVADA_FINSI
        }

        private static void ProcessState9()
        {
            if (IsN())
            {
                Concatenate();
                INSTANCE.CurrentState = 8;
            }
            else
            {
                INSTANCE.CurrentState = 73;
            }
        }

        private static void ProcessState10()
        {
            if (IsI())
            {
                Concatenate();
                INSTANCE.CurrentState = 9;
            }
            else
            {
                INSTANCE.CurrentState = 74;
            }
        }

        private static void ProcessState11()
        {
            //ERROR
        }

        private static void ProcessState12()
        {
            //RETORNAR Y
        }

        private static void ProcessState14()
        {
            //RETORNAR O
        }

        private static void ProcessState16()
        {
            if (IsP())
            {
                Concatenate();
                INSTANCE.CurrentState = 17;
            }
            else
            {
                INSTANCE.CurrentState = 76;
            }
        }

        private static void ProcessState17()
        {
            if (IsR())
            {
                Concatenate();
                INSTANCE.CurrentState = 18;
            }
            else
            {
                INSTANCE.CurrentState = 77;
            }
        }

        private static void ProcessState18()
        {
            if (IsI())
            {
                Concatenate();
                INSTANCE.CurrentState = 19;
            }
            else
            {
                INSTANCE.CurrentState = 78;
            }
        }

        private static void ProcessState19()
        {
            if (IsM())
            {
                Concatenate();
                INSTANCE.CurrentState = 20;
            }
            else
            {
                INSTANCE.CurrentState = 79;
            }
        }

        private static void ProcessState20()
        {
            if (IsI())
            {
                Concatenate();
                INSTANCE.CurrentState = 21;
            }
            else
            {
                INSTANCE.CurrentState = 80;
            }
        }

        private static void ProcessState21()
        {
            if (IsR())
            {
                Concatenate();
                INSTANCE.CurrentState = 22;
            }
            else
            {
                INSTANCE.CurrentState = 81;
            }
        }

        private static void ProcessState22()
        {
            //RETORNAR IMPRIMIR
        }

        private static void ProcessState24()
        {
            if (IsM())
            {
                Concatenate();
                INSTANCE.CurrentState = 16;
            }
            else if (IsN())
            {
                Concatenate();
                INSTANCE.CurrentState = 25;
            }
            else
            {
                INSTANCE.CurrentState = 75;
            }
        }

        private static void ProcessState25()
        {
            if (IsI())
            {
                Concatenate();
                INSTANCE.CurrentState = 26;
            }
            else
            {
                INSTANCE.CurrentState = 85;
            }
        }

        private static void ProcessState26()
        {
            if (IsC())
            {
                Concatenate();
                INSTANCE.CurrentState = 27;
            }
            else
            {
                INSTANCE.CurrentState = 84;
            }
        }

        private static void ProcessState27()
        {
            if (IsI())
            {
                Concatenate();
                INSTANCE.CurrentState = 28;
            }
            else
            {
                INSTANCE.CurrentState = 83;
            }
        }

        private static void ProcessState28()
        {
            if (IsO())
            {
                Concatenate();
                INSTANCE.CurrentState = 29;
            }
            else
            {
                INSTANCE.CurrentState = 82;
            }
        }

        private static void ProcessState29()
        {
            //RETORNAR INICIO
        }
        private static void ProcessState31()
        {
            if (IsMinusc() || IsA() || IsB() || IsC() || IsD() || IsE() || IsG() || IsH() || IsJ() || IsK() || IsM() || IsN() || IsP()
                || IsQ() || IsR() || IsT() || IsU() || IsV() || IsW() || IsX() || IsZ() || IsDigit())
            {
                Concatenate();
                INSTANCE.CurrentState = 31;
            }
            else
            {
                INSTANCE.CurrentState = 32;
            }
        }

        private static void ProcessState32()
        {
            CreateComponentReturningIndex(Category.IDENTIFICADOR, ComponentType.NORMAL);
        }
        private static void ProcessState33()
        {
            if (IsI())
            {
                Concatenate();
                INSTANCE.CurrentState = 34;
            }
        }
        private static void ProcessState34()
        {
            if (IsN())
            {
                Concatenate();
                INSTANCE.CurrentState = 36;
            }
            else
            {
                INSTANCE.CurrentState = 35;
            }

        }

        private static void ProcessState35()
        {
            Return(Category.PALABRA_RESERVADA_SI);
        }
        private static void ProcessState36()
        {
            if (IsO())
            {
                Concatenate();
                INSTANCE.CurrentState = 37;

            }
            else
            {
                INSTANCE.CurrentState = 87;
            }
        }
        private static void ProcessState37()
        {
            Return(Category.PALABRA_RESERVADA_SINO);
        }
        private static void ProcessState38()
        {
            if (IsDigit())
            {
                Concatenate();
                INSTANCE.CurrentState = 38;
            }
            else
            {

                INSTANCE.CurrentState = 54;
            }
        }
        private static void ProcessState39()
        {
            if (IsDigit())
            {
                Concatenate();
                INSTANCE.CurrentState = 38;
            }
            else
            {
                INSTANCE.CurrentState = 53;
            }
        }
        private static void ProcessState40()
        {
            if (IsDigit())
            {
                Concatenate();
                INSTANCE.CurrentState = 40;
            }
            else
            {
                INSTANCE.CurrentState = 57;
            }
        }
        private static void ProcessState41()
        {
            CreateComponentWithouReturnIndex(Category.DIVISION, ComponentType.NORMAL);
        }
        private static void ProcessState42()
        {
            CreateComponentWithouReturnIndex(Category.MULTIPLICACION, ComponentType.NORMAL);
        }
        private static void ProcessState43()
        {
            CreateComponentWithouReturnIndex(Category.RESTA, ComponentType.NORMAL);
        }
        private static void ProcessState44()
        {
            CreateComponentWithouReturnIndex(Category.SUMA, ComponentType.NORMAL);
        }
        private static void ProcessState45()
        {
            CreateComponentWithouReturnIndex(Category.IGUAL_QUE, ComponentType.NORMAL);
        }
        private static void ProcessState46()
        {
            if (IsEqual())
            {
                Concatenate();
                INSTANCE.CurrentState = 48;
            }
            else if (IsGreaterThan())
            {
                Concatenate();
                INSTANCE.CurrentState = 50;
            }
            else
            {
                INSTANCE.CurrentState = 49;
            }

        }
        private static void ProcessState47()
        {
            if (IsEqual())
            {
                Concatenate();
                INSTANCE.CurrentState = 51;
            }
            else
            {
                INSTANCE.CurrentState = 52;
            }
        }
        private static void ProcessState48()
        {
            Return(Category.MENOR_IGUAL_QUE);
        }
        private static void ProcessState49()
        {
            CreateComponentReturningIndex(Category.MENOR_QUE, ComponentType.NORMAL);
        }
        private static void ProcessState50()
        {
            CreateComponentWithouReturnIndex(Category.DIFERENTE_QUE, ComponentType.NORMAL);
        }
        private static void ProcessState51()
        {
            CreateComponentWithouReturnIndex(Category.MAYOR_IGUAL_QUE, ComponentType.NORMAL);
        }
        private static void ProcessState52()
        {
            CreateComponentReturningIndex(Category.MAYOR_QUE, ComponentType.NORMAL);
        }
        private static void ProcessState53()
        {
            ThrowErrorAndBack("ERROR SE ESPERABA UN DIGITO O UNA *.* Y SE RECIBIO (CARACTER ACTUAL) NUMERO DECIMAL NO VALIDO");
        }
        private static void ProcessState54()
        {
            CreateComponentReturningIndex(Category.DECIMAL, ComponentType.NORMAL);
        }
        private static void ProcessState55()
        {
            LoadNewLine();
            INSTANCE.CurrentState = 0;
        }
        private static void ProcessState56()
        {
            if (IsEndOfLine() || IsMultiplication())
            {
                Concatenate();
                INSTANCE.CurrentState = 56;
            }
            else if (IsEndOfLine())
            {
                Concatenate();
                INSTANCE.CurrentState = 71;
            }

        }
        private static void ProcessState57()
        {
            Return(Category.PALABRA_RESERVADA_FINSI);
        }
        private static void ProcessState58()
        {
            if (IsE())
            {
                Concatenate();
                INSTANCE.CurrentState = 59;
            }
        }

        private static void ProcessState59()
        {
            DevourBlankCharacter();
            if (IsA())
            {
                Concatenate();
                INSTANCE.CurrentState = 60;
            }
        }

        private static void ProcessState60()
        {
            CreateComponentWithouReturnIndex(Category.ENTRADA_DATOS, ComponentType.NORMAL);
        }
        private static void ProcessState62()
        {
            CreateComponentWithouReturnIndex(Category.LLAVE_ABRE, ComponentType.NORMAL);
        }
        private static void ProcessState64()
        {
            CreateComponentWithouReturnIndex(Category.LLAVE_CIERRA, ComponentType.NORMAL);
        }

        private static void ProcessState66()
        {
            DevourBlankCharacter();
            if (IsAnyBut("@FL@"))
            {
                INSTANCE.CurrentState = 0;
            }
            else
            {
                INSTANCE.CurrentState = 55;
            }
        }

        private static void ProcessState67()
        {
            CreateComponentReturningIndex(Category.ENTERO, ComponentType.NORMAL);
        }

        private static void ProcessState68()
        {
            LoadNewLine();
            INSTANCE.CurrentState = 0;
        }

        private static void ProcessState69()
        {
            DevourBlankCharacter();
            if (IsEqual())
            {
                Concatenate();
                INSTANCE.CurrentState = 45;
            }
            else
            {
                Concatenate();
                INSTANCE.CurrentState = 70;
            }
        }

        private static void ProcessState70()
        {
            CreateComponentReturningIndex(Category.ASIGNACION, ComponentType.NORMAL);
        }

        private static void ProcessState71()
        {
            string fail = "Componente lexico no valido...";
            string cause = "Error se terminó la linea sin cerrar la cadena, cadena no valida...";
            string solution = "Agregue una comilla al final de la linea...";
            CreateLexicalError(ErrorType.STOPPER, fail, cause, solution, Category.GENERAL, INSTANCE.Lexeme + Scanner.GetCurrentCharacter());
        }

        private static void ProcessState72()
        {
            DevourBlankCharacter();
            if (IsSlash())
            {
                Concatenate();
            }
            else if (IsEndOfLine())
            {
                INSTANCE.CurrentState = 88;
            }
            else if (IsAnyBut("@FL@") && IsAnyBut("/"))
            {
                Concatenate();
                INSTANCE.CurrentState = 56;
            }
        }

        private static void ProcessState73()
        {
            string fail = "Componente lexico no valido...";
            string cause = "Error se esperaba N para formar un FIN valido,se recibió (caracter actual)...";
            string solution = "Si pretende formar un FIN, cambien el caracter actual por una N...";
            CreateLexicalError(ErrorType.STOPPER, fail, cause, solution, Category.GENERAL, INSTANCE.Lexeme + Scanner.GetCurrentCharacter());
        }

        private static void ProcessState74()
        {
            string fail = "Componente lexico no valido...";
            string cause = "Error se esperaba I para formar un FIN valido, se recibió (caracter actual)...";
            string solution = "Si pretende formar un FIN, cambien el caracter actual por una I...";
            CreateLexicalError(ErrorType.STOPPER, fail, cause, solution, Category.GENERAL, INSTANCE.Lexeme + Scanner.GetCurrentCharacter());
        }

        private static void ProcessState75()
        {
            string fail = "Componente lexico no valido...";
            string cause = "Error se esperaba M o N para formar un imprimir o inicio validos, se recibió (caracter actual)";
            string solution = "Si pretende formar un IMPRIMIR, cambie el caracter actual por una M...";
            CreateLexicalError(ErrorType.STOPPER, fail, cause, solution, Category.GENERAL, INSTANCE.Lexeme + Scanner.GetCurrentCharacter());
        }

        private static void ProcessState76()
        {
            string fail = "Componente lexico no valido...";
            string cause = "Error se esperaba P para formar un imprimir valido, se recibió (caracter actual)";
            string solution = "Si pretende formar un IMPRIMIR, cambie el caracter actual por una P...";
            CreateLexicalError(ErrorType.STOPPER, fail, cause, solution, Category.GENERAL, INSTANCE.Lexeme + Scanner.GetCurrentCharacter());
        }
        private static void ProcessState77()
        {
            string fail = "Componente lexico no valido...";
            string cause = "Error se esperaba R para formar un imprimir valido, se recibió (caracter actual)";
            string solution = "Si pretende formar un IMPRIMIR, cambie el caracter actual por una R...";
            CreateLexicalError(ErrorType.STOPPER, fail, cause, solution, Category.GENERAL, INSTANCE.Lexeme + Scanner.GetCurrentCharacter());
        }
        private static void ProcessState78()
        {
            string fail = "Componente lexico no valido...";
            string cause = "Error se esperaba I para formar un imprimir valido, se recibió (caracter actual)";
            string solution = "Si pretende formar un IMPRIMIR, cambie el caracter actual por una I...";
            CreateLexicalError(ErrorType.STOPPER, fail, cause, solution, Category.GENERAL, INSTANCE.Lexeme + Scanner.GetCurrentCharacter());
        }
        private static void ProcessState79()
        {
            string fail = "Componente lexico no valido...";
            string cause = "Error se esperaba M para formar un imprimir valido, se recibió (caracter actual)";
            string solution = "Si pretende formar un IMPRIMIR, cambie el caracter actual por una M...";
            CreateLexicalError(ErrorType.STOPPER, fail, cause, solution, Category.GENERAL, INSTANCE.Lexeme + Scanner.GetCurrentCharacter());
        }

        private static void ProcessState80()
        {
            string fail = "Componente lexico no valido...";
            string cause = "Error se esperaba I para formar un imprimir valido, se recibió (caracter actual)";
            string solution = "Si pretende formar un IMPRIMIR, cambie el caracter actual por una I...";
            CreateLexicalError(ErrorType.STOPPER, fail, cause, solution, Category.GENERAL, INSTANCE.Lexeme + Scanner.GetCurrentCharacter());
        }

        private static void ProcessState81()
        {
            string fail = "Componente lexico no valido...";
            string cause = "Error se esperaba R para formar un imprimir valido, se recibió (caracter actual)";
            string solution = "Si pretende formar un IMPRIMIR, cambie el caracter actual por una R...";
            CreateLexicalError(ErrorType.STOPPER, fail, cause, solution, Category.GENERAL, INSTANCE.Lexeme + Scanner.GetCurrentCharacter());
        }

        private static void ProcessState82()
        {
            string fail = "Componente lexico no valido...";
            string cause = "Error se esperaba O para formar un inicio valido, se recibió (caracter actual)";
            string solution = "Si pretende formar un INICIO, cambie el caracter actual por una O...";
            CreateLexicalError(ErrorType.STOPPER, fail, cause, solution, Category.GENERAL, INSTANCE.Lexeme + Scanner.GetCurrentCharacter());
        }
        private static void ProcessState83()
        {
            string fail = "Componente lexico no valido...";
            string cause = "Error se esperaba I para formar un inicio valido, se recibió (caracter actual)";
            string solution = "Si pretende formar un INICIO, cambie el caracter actual por una I...";
            CreateLexicalError(ErrorType.STOPPER, fail, cause, solution, Category.GENERAL, INSTANCE.Lexeme + Scanner.GetCurrentCharacter());
        }
        private static void ProcessState84()
        {
            string fail = "Componente lexico no valido...";
            string cause = "Error se esperaba C para formar un inicio valido,se recibió (caracter actual)";
            string solution = "Si pretende formar un INICIO, cambie el caracter actual por una C...";
            CreateLexicalError(ErrorType.STOPPER, fail, cause, solution, Category.GENERAL, INSTANCE.Lexeme + Scanner.GetCurrentCharacter());
        }
        private static void ProcessState85()
        {
            string fail = "Componente lexico no valido...";
            string cause = "Error se esperaba I para formar un inicio valido,se recibió (caracter actual)";
            string solution = "Si pretende formar un INICIO, cambie el caracter actual por una I...";
            CreateLexicalError(ErrorType.STOPPER, fail, cause, solution, Category.GENERAL, INSTANCE.Lexeme + Scanner.GetCurrentCharacter());
        }
        private static void ProcessState86()
        {
            string fail = "Componente lexico no valido...";
            string cause = "Error se esperaba N para formar un inicio valido,se recibió (caracter actual)";
            string solution = "Si pretende formar un INICIO, cambie el caracter actual por una N...";
            CreateLexicalError(ErrorType.STOPPER, fail, cause, solution, Category.GENERAL, INSTANCE.Lexeme + Scanner.GetCurrentCharacter());
        }
        private static void ProcessState87()
        {
            string fail = "Componente lexico no valido...";
            string cause = "Error se esperaba o para formar un SINO, se recibió (caracter actual)";
            string solution = "Si pretende formar un SINO, cambie el caracter actual por una N...";
            CreateLexicalError(ErrorType.STOPPER, fail, cause, solution, Category.GENERAL, INSTANCE.Lexeme + Scanner.GetCurrentCharacter());
        }
        private static void ProcessState88()
        {
            string fail = "Componente lexico no valido...";
            string cause = "Error, se terminó la linea sin cerrar la cadena, cadena no valida";
            string solution = "Agregue una comilla al final de la linea...";
            CreateLexicalError(ErrorType.STOPPER, fail, cause, solution, Category.GENERAL, INSTANCE.Lexeme + Scanner.GetCurrentCharacter());
        }
        private static void ProcessState89()
        {
            string fail = "Componente lexico no valido...";
            string cause = "Error, se esperaba una A para formar un LEA valido,se recibió (caracter actual) entrada de datos no valida";
            string solution = "Si pretende formar un LEA, cambie el caracter actual por una A...";
            CreateLexicalError(ErrorType.STOPPER, fail, cause, solution, Category.GENERAL, INSTANCE.Lexeme + Scanner.GetCurrentCharacter());
        }


        private static void CreateComponent(Category category, ComponentType type)
        {
            int lineNumber = Scanner.GetCurrentNumberLine();
            int initialPosition = Scanner.GetCurrentIndex() - INSTANCE.Lexeme.Length;
            int finalPosition = Scanner.GetCurrentIndex() - 1;

            if (ComponentType.NORMAL.Equals(type))
            {
                INSTANCE.Component = LexicalComponent.CreateNormalComponent(lineNumber, initialPosition, finalPosition, category, INSTANCE.Lexeme);
            }
            else if (ComponentType.DUMMY.Equals(type))
            {
                INSTANCE.Component = LexicalComponent.CreateDummyComponent(lineNumber, initialPosition, finalPosition, category, INSTANCE.Lexeme);
            }
        }

        private static void CreateLexicalError(ErrorType errorType, string fail, string cause, string solution, Category expecteCategory, string lexeme)
        {
            int lineNumber = Scanner.GetCurrentNumberLine();

            Error error;

            if (ErrorType.STOPPER.Equals(errorType))
            {
                int initialPosition = Scanner.GetCurrentIndex() - 1;
                int finalPosition = Scanner.GetCurrentIndex() - 1;
                error = Error.CreateStopperLexicalError(lineNumber, initialPosition, finalPosition, fail, cause, solution, expecteCategory, lexeme);

                ErrorManagement.Agregar(error);
                throw new Exception("Se ha presentado un error tipo STOPPER durante el análisis lexico. No es posible continuar con el proceso de compílación gasta que el error haya solucionado. Por favor verifique la consola de errores para tener más detalles del problema que se ha presentado....");
            }
            else if (ErrorType.CONTROLABLE.Equals(errorType))
            {
                int initialPosition = Scanner.GetCurrentIndex() - INSTANCE.Lexeme.Length;
                int finalPosition = Scanner.GetCurrentIndex() - 1;

                error = Error.CreateStopperLexicalError(lineNumber, initialPosition, finalPosition, fail, cause, solution, expecteCategory, lexeme);
                ErrorManagement.Agregar(error);
            }


        }

        private static void CreateComponentWithouReturnIndex(Category category, ComponentType type)
        {
            INSTANCE.Continue = false;

            CreateComponent(category, type);
        }

        private static void CreateComponentReturningIndex(Category category, ComponentType type)
        {
            Scanner.ReturnIndex();
            INSTANCE.Continue = false;

            CreateComponent(category, type);
        }







        private static bool IsLetter()
        {
            return Char.IsLetter(Scanner.GetCurrentCharacter().ToCharArray()[0]);
        }

        private static bool IsAny()
        {
            return IsLetter() || IsDigit() || IsCurrency() || IsUnderline() || IsAddition() || IsMinus() || IsMultiplication() || IsSlash() || IsEqual() || IsGreaterThan() || IsLessThan() || IsLeftParenthesis() || IsRightParenthesis() || IsComma() || IsAt() || IsEndOfLine();
        }
        private static bool IsAnyBut(String character)
        {
            if (character.Equals(Scanner.GetCurrentCharacter().ToCharArray()[0]))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static bool IsDigit()
        {
            return Char.IsDigit(Scanner.GetCurrentCharacter().ToCharArray()[0]);
        }

        private static bool IsCurrency()
        {
            return "$".Equals(Scanner.GetCurrentCharacter());
        }

        private static bool IsUnderline()
        {
            return "_".Equals(Scanner.GetCurrentCharacter());
        }

        private static bool IsAddition()
        {
            return "+".Equals(Scanner.GetCurrentCharacter());
        }

        private static bool IsMinusc()
        {
            return Char.IsLower(Scanner.GetCurrentCharacter().ToCharArray()[0]);
        }
        private static bool IsMinus()
        {
            return "-".Equals(Scanner.GetCurrentCharacter());
        }

        private static bool IsMultiplication()
        {
            return "*".Equals(Scanner.GetCurrentCharacter());
        }

        private static bool IsSlash()
        {
            return "/".Equals(Scanner.GetCurrentCharacter());
        }

        private static bool IsEqual()
        {
            return "=".Equals(Scanner.GetCurrentCharacter());
        }

        private static bool IsGreaterThan()
        {
            return ">".Equals(Scanner.GetCurrentCharacter());
        }

        private static bool IsLessThan()
        {
            return "<".Equals(Scanner.GetCurrentCharacter());
        }

        private static bool IsLeftParenthesis()
        {
            return "(".Equals(Scanner.GetCurrentCharacter());
        }

        private static bool IsRightParenthesis()
        {
            return ")".Equals(Scanner.GetCurrentCharacter());
        }

        private static bool IsComma()
        {
            return ",".Equals(Scanner.GetCurrentCharacter());
        }

        private static bool IsAt()
        {
            return "@".Equals(Scanner.GetCurrentCharacter());
        }
        private static bool IsEndOfLine()
        {
            return "@FL@".Equals(Scanner.GetCurrentCharacter());
        }

        private static bool IsQuotationMark()
        {
            return '"'.Equals(Scanner.GetCurrentCharacter());
        }

        private static bool IsOpenBrace()
        {
            return "{".Equals(Scanner.GetCurrentCharacter());
        }

        private static bool IsCloseBrace()
        {
            return "}".Equals(Scanner.GetCurrentCharacter());
        }
        private static bool IsFL()
        {
            return "@FL@".Equals(Scanner.GetCurrentCharacter());
        }
        private static bool IsEOF()
        {
            return "@EOF@".Equals(Scanner.GetCurrentCharacter());
        }
        private static bool IsA()
        {
            return "A".Equals(Scanner.GetCurrentCharacter());
        }
        private static bool IsB()
        {
            return "B".Equals(Scanner.GetCurrentCharacter());
        }
        private static bool IsC()
        {
            return "C".Equals(Scanner.GetCurrentCharacter());
        }
        private static bool IsD()
        {
            return "D".Equals(Scanner.GetCurrentCharacter());
        }
        private static bool IsE()
        {
            return "E".Equals(Scanner.GetCurrentCharacter());
        }
        private static bool IsF()
        {
            return "F".Equals(Scanner.GetCurrentCharacter());
        }
        private static bool IsG()
        {
            return "G".Equals(Scanner.GetCurrentCharacter());
        }
        private static bool IsH()
        {
            return "H".Equals(Scanner.GetCurrentCharacter());
        }
        private static bool IsI()
        {
            return "I".Equals(Scanner.GetCurrentCharacter());
        }
        private static bool IsJ()
        {
            return "J".Equals(Scanner.GetCurrentCharacter());
        }
        private static bool IsK()
        {
            return "K".Equals(Scanner.GetCurrentCharacter());
        }
        private static bool IsL()
        {
            return "L".Equals(Scanner.GetCurrentCharacter());
        }
        private static bool IsM()
        {
            return "M".Equals(Scanner.GetCurrentCharacter());
        }
        private static bool IsN()
        {
            return "N".Equals(Scanner.GetCurrentCharacter());
        }
        private static bool IsO()
        {
            return "O".Equals(Scanner.GetCurrentCharacter());
        }
        private static bool IsP()
        {
            return "P".Equals(Scanner.GetCurrentCharacter());
        }
        private static bool IsQ()
        {
            return "Q".Equals(Scanner.GetCurrentCharacter());
        }
        private static bool IsR()
        {
            return "R".Equals(Scanner.GetCurrentCharacter());
        }
        private static bool IsS()
        {
            return "S".Equals(Scanner.GetCurrentCharacter());
        }
        private static bool IsT()
        {
            return "T".Equals(Scanner.GetCurrentCharacter());
        }
        private static bool IsU()
        {
            return "U".Equals(Scanner.GetCurrentCharacter());
        }
        private static bool IsV()
        {
            return "V".Equals(Scanner.GetCurrentCharacter());
        }
        private static bool IsW()
        {
            return "W".Equals(Scanner.GetCurrentCharacter());
        }
        private static bool IsX()
        {
            return "X".Equals(Scanner.GetCurrentCharacter());
        }
        private static bool IsY()
        {
            return "Y".Equals(Scanner.GetCurrentCharacter());
        }
        private static bool IsZ()
        {
            return "Z".Equals(Scanner.GetCurrentCharacter());
        }
    }
}
