using System;
using System.Windows.Forms;

public static class Validacao
{
    public static bool ValidaCpf(string cpf)
    {
        //COMMIT TESTE PROVA
        cpf = cpf.Replace(",", "");
        cpf = cpf.Replace("-", "");

        //MessageBox.Show(cpf);

        int soma = 0;
        int digito = 0;
        int resto = 0;
        int digito1 = 0;
        int digito2 = 0;

        if(cpf.Length == 11)
        {
            //multiplica os 9 primeiro 
            //int cont = 0;//elias
            
            for(int i = 0; i < 9; i++)
            {
                //digito = Convert.ToInt32(cpf[0]), cpf[0] é igual a 0 (032.877.232-19), só que tá em string
                digito = Convert.ToInt32(cpf[i].ToString());// msm coisa que digito = Convert.ToInt32("0");
                //cont++; elias
                //soma = soma + 0 * 10; soma = soma + 0; soma = 0;
                //0 = 0 + 3 * 9; 0 = 0 + 27; 0 = 27;
                //27 = 27 + 2 * 8; 27 = 27 + 16; 27 = 43;
                //43 = 43 + 8 * 7; 43 = 43 + 56; 43 = 99;
                //99 = 99 + 7 * 6; 99 = 99 + 42; 99 = 141;
                //141 = 141 + 7 * 5; 141 = 141 + 35; 141 = 176;
                //176 = 176 + 2 * 4; 176 =  176 + 8; 176 = 184;
                //184 = 184 + 3 * 3; 184 = 184 + 9; 184 = 193;
                //193 = 193 + 2 * 2; 184 = 193 + 4; 184 = 197;
                //soma = 197;

                soma = soma + digito * (10 - i);
            }

            resto = soma % 11;//calcula o valor do primeiro digito depois do traço, nesse caso, seria o 1 (-19)
                              //ex: 197 % 11 = 10

            if(resto < 2)
            {
                digito1 = 0;
                //se o resto for menor que 2, o primeiro digito depois do traço deveria ser 0
            }

            else //if (resto > 2)
            {
                digito1 = 11 - resto;
                //se o resto for maior que 2, tem que fazer a subtração pra descobrir qual deveria ser o primeiro digito
                //ex: digito1 = 11 - 10; digito1 = 1; nesse caso o primeiro digito dps do traço DEVERIA ser 1
            }

            //verifica o primeiro digito depois do traço, que seria o 1
            //compara a variavel digito1 com o primeiro digito dps do traço
            //ex: digito1 é diferente de 1? 1 é diferente de 1?, se for diferente, o cpf já é falso

            if (digito1.ToString() != cpf[9].ToString())
            {
                return false;
            }
            
            //if (digito1.ToString() == cpf[9].ToString())se for igual, prossegue para verificar o segundo digito
            //{
                soma = 0;
                //cont = 0;//elias
                for(int i = 0; i < 10; i++)//multiplica os 10 primeiros digitos, agr conta o 1 dps do traço
                {
                    digito = Convert.ToInt32(cpf[i].ToString());
                    //cont++;//elias
                    soma = soma + digito * (11 - i);
                    //soma = soma + 0 * 11; soma = soma + 0; soma = 0;
                    //0 = 0 + 3 * 10; 0 = 0 + 30; 0 = 30;
                    //30 = 30 + 2 * 9; 30 = 30 + 18; 30 = 48;
                    //48 = 48 + 8 * 8; 48 = 48 + 64; 48 = 112;
                    //112 = 112 + 7 * 7 = 112 + 49; 112 = 161;
                    //161 = 161 + 7 * 6 = 161 + 42; 161 = 203;
                    //203 = 203 + 2 * 5 = 203 + 10; 203 = 213;
                    //213 = 213 + 3 * 4 = 213 + 12; 213 = 225;
                    //225 = 225 + 2 * 3 = 225 + 6; 225 = 231;
                    //231 = 231 + 1 * 2 = 231 + 2; 231 = 233;
                }

                resto = soma % 11;

                if (resto < 2)
                {
                    digito2 = 0;
                    //se o resto for menor que 2, o primeiro digito depois do traço deveria ser 0
                }

                else //if (resto > 2)
                {
                    digito2 = 11 - resto;
                    //se o resto for maior que 2, tem que fazer a subtração pra descobrir qual deveria ser o primeiro digito
                }

                if(digito2.ToString() != cpf[10].ToString())
                {
                    return false;
                }

                else
                {
                    return true;
                }
            //}

            /*else //if (digito1.ToString() != cpf[9].ToString())
            {
                return false;
            }*/
        }

        else
        {
            return false;
        }
    }
}