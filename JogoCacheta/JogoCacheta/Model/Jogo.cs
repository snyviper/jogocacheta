using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JogoCacheta.Database;

namespace JogoCacheta.Model
{
    static class Jogo
    {
        public static Crud crud = new Crud();
        private static byte Vitoria(int cod)
        {
            byte qtdjog = crud.GetQtdJog(cod);
            byte count = qtdjog, winner = 0;
            if (crud.GetPontos1(cod) == 0)
            {
                count--;
            }
            else
            {
                winner = 1;
            }
            if (crud.GetPontos2(cod) == 0)
            {
                count--;
            }
            else
            {
                winner = 2;
            }
            if (qtdjog > 2)
            {
                if (crud.GetPontos3(cod) == 0)
                {
                    count--;
                }
                else
                {
                    winner = 3;
                }
                if (qtdjog > 3)
                {
                    if (crud.GetPontos4(cod) == 0)
                    {
                        count--;
                    }
                    else
                    {
                        winner = 4;
                    }
                    if (qtdjog > 4)
                    {
                        if (crud.GetPontos5(cod) == 0)
                        {
                            count--;
                        }
                        else
                        {
                            winner = 5;
                        }
                    }
                }
            }
            if (count < 2)
            {
                return winner;
            }
            return 0;
        }
        public static bool NovaRodada(int cod, byte jog1, byte jog2)
        {
            switch (jog1)
            {
                case 0: // fold
                    crud.Jog1Fold(cod);
                    break;
                case 1: // loss
                    crud.Jog1Lose(cod);
                    break;
                    // 2 = win
            }
            switch (jog2)
            {
                case 0: // fold
                    crud.Jog2Fold(cod);
                    break;
                case 1: // loss
                    crud.Jog2Lose(cod);
                    break;
                    // 2 = win
            }
            if (Vitoria(cod) > 0)
            {
                crud.SetGanhador(cod, Vitoria(cod));
                return true;
            }
            else
            {
                crud.NovaRodada(cod);
                return false;
            }
        }
        public static bool NovaRodada(int cod, byte jog1, byte jog2, byte jog3)
        {
            switch (jog1)
            {
                case 0: // fold
                    crud.Jog1Fold(cod);
                    break;
                case 1: // loss
                    crud.Jog1Lose(cod);
                    break;
                    // 2 = win
            }
            switch (jog2)
            {
                case 0: // fold
                    crud.Jog2Fold(cod);
                    break;
                case 1: // loss
                    crud.Jog2Lose(cod);
                    break;
                    // 2 = win
            }
            switch (jog3)
            {
                case 0: // fold
                    crud.Jog3Fold(cod);
                    break;
                case 1: // loss
                    crud.Jog3Lose(cod);
                    break;
                    // 2 = win
            }
            if (Vitoria(cod) > 0)
            {
                crud.SetGanhador(cod, Vitoria(cod));
                return true;
            }
            else
            {
                crud.NovaRodada(cod);
                return false;
            }
        }
        public static bool NovaRodada(int cod, byte jog1, byte jog2, byte jog3, byte jog4)
        {
            switch (jog1)
            {
                case 0: // fold
                    crud.Jog1Fold(cod);
                    break;
                case 1: // loss
                    crud.Jog1Lose(cod);
                    break;
                    // 2 = win
            }
            switch (jog2)
            {
                case 0: // fold
                    crud.Jog2Fold(cod);
                    break;
                case 1: // loss
                    crud.Jog2Lose(cod);
                    break;
                    // 2 = win
            }
            switch (jog3)
            {
                case 0: // fold
                    crud.Jog3Fold(cod);
                    break;
                case 1: // loss
                    crud.Jog3Lose(cod);
                    break;
                    // 2 = win
            }
            switch (jog4)
            {
                case 0: // fold
                    crud.Jog4Fold(cod);
                    break;
                case 1: // loss
                    crud.Jog4Lose(cod);
                    break;
                    // 2 = win
            }
            if (Vitoria(cod) > 0)
            {
                crud.SetGanhador(cod, Vitoria(cod));
                return true;
            }
            else
            {
                crud.NovaRodada(cod);
                return false;
            }
        }
        public static bool NovaRodada(int cod, byte jog1, byte jog2, byte jog3, byte jog4, byte jog5)
        {
            switch (jog1)
            {
                case 0: // fold
                    crud.Jog1Fold(cod);
                    break;
                case 1: // loss
                    crud.Jog1Lose(cod);
                    break;
                    // 2 = win
            }
            switch (jog2)
            {
                case 0: // fold
                    crud.Jog2Fold(cod);
                    break;
                case 1: // loss
                    crud.Jog2Lose(cod);
                    break;
                    // 2 = win
            }
            switch (jog3)
            {
                case 0: // fold
                    crud.Jog3Fold(cod);
                    break;
                case 1: // loss
                    crud.Jog3Lose(cod);
                    break;
                    // 2 = win
            }
            switch (jog4)
            {
                case 0: // fold
                    crud.Jog4Fold(cod);
                    break;
                case 1: // loss
                    crud.Jog4Lose(cod);
                    break;
                    // 2 = win
            }
            switch (jog5)
            {
                case 0: // fold
                    crud.Jog5Fold(cod);
                    break;
                case 1: // loss
                    crud.Jog5Lose(cod);
                    break;
                    // 2 = win
            }
            if (Vitoria(cod) > 0)
            {
                crud.SetGanhador(cod, Vitoria(cod));
                return true;
            }
            else
            {
                crud.NovaRodada(cod);
                return false;
            }
        }
        public static int NovoJogo(byte qtdjog, byte maxpontos)
        {
            return crud.NovoJogo(qtdjog, maxpontos);
        }
        public static byte GetGanhador(int cod)
        {
            return crud.GetGanhador(cod);
        }
        public static byte GetRodada(int cod)
        {
            return crud.GetRodada(cod);
        }
        public static byte GetPontos1(int cod)
        {
            return crud.GetPontos1(cod);
        }
        public static byte GetPontos2(int cod)
        {
            return crud.GetPontos2(cod);
        }
        public static byte GetPontos3(int cod)
        {
            return crud.GetPontos3(cod);
        }
        public static byte GetPontos4(int cod)
        {
            return crud.GetPontos4(cod);
        }
        public static byte GetPontos5(int cod)
        {
            return crud.GetPontos5(cod);
        }
    }
}
