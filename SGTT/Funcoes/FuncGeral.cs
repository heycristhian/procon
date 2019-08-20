using SGAP.Forms;
using SGAP.Modelo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGAP.Funcoes
{
    class FuncGeral
    {
        public static void labelCorLeave(Label label)
        {
            label.BackColor = System.Drawing.Color.White;
            label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(89)))), ((int)(((byte)(168)))));
        }

        public static void labelCorEnter(Label label)
        {
            label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));
            label.ForeColor = System.Drawing.Color.White;
        }

        public static void messageBoxEditar()
        {
            MessageBox.Show("Não há registros para editar!", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void labelFecharCorEnter(Label label)
        {
            label.BackColor = Color.Red;
        }

        public static void labelFecharCorLeave(Label label)
        {
            label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(79)))), ((int)(((byte)(95)))));
        }

        public static bool validarEmail(TextBox txt)
        {
            if(!(txt.Text == ""))
            {
                string email = txt.Text;
                Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");
                if (rg.IsMatch(email))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("O e-mail é inválido!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt.Focus();
                    return false;
                }
            }
            else
            {
                return true;
            }
            
        }

        public static bool tratamentoCep(TextBox txt)
        {
            try
            {                               
                txt.Text = txt.Text.Replace("-", "");
                if (txt.Text == "")
                {
                    return true;
                }
                else if(txt.Text.Count() == 8 && !(txt.Text.Contains("-")))
                {
                    txt.Text = txt.Text.Substring(0, 5) + "-" + txt.Text.Substring(5);
                    return true;
                }
                else
                {
                    MessageBox.Show("CEP deve conter 8 dígitos!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt.Focus();
                    return false;
                }                
            }
            catch (Exception)
            {
                return false;
            }

        }        

        public static bool tratamentoTel(TextBox txt)
        {
            try
            {                
                txt.Text = txt.Text.Replace("-", "").Replace("(", "").Replace(")", "");
                if (txt.Text == "")
                {
                    return true;
                }
                else if (txt.Text.Count() == 11)
                {
                    txt.Text = "(" + txt.Text.Substring(0, 2) + ")" + txt.Text.Substring(2, 5) + "-" + txt.Text.Substring(7);
                    return true;
                }
                else if (txt.Text.Count() == 10)
                {
                    txt.Text = "(" + txt.Text.Substring(0, 2) + ")" + txt.Text.Substring(2, 4) + "-" + txt.Text.Substring(6);
                    return true;
                }
                else
                {
                    MessageBox.Show("Número deve conter DDD + número!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt.Focus();
                    return false;
                }                       
            }
            catch (Exception)
            {
                return false;
            }
        }

        //Escluir depois
        private Consumidor cpfExist(string cpf) //CPF e CNPJ FUNCIONA
        {
            SGAP.Modelo.SGAPContexto contexto = new SGAPContexto();
            return contexto.Consumidor.ToList().FirstOrDefault(t => t.cpf.CompareTo(cpf) == 0);
        }

        public static bool tratamentoCpfConsumidor(TextBox txt)
        {          
            if (txt.Text != "")
            {
                string cpf = txt.Text.Replace(".", "").Replace("-", "").Replace("/", "");

                if (ValidaCpf.IsCpf(txt.Text) != true)
                {
                    MessageBox.Show("CPF inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt.Focus();
                    return false;
                }
                else
                {
                    txt.Text = Convert.ToUInt64(cpf).ToString(@"000\.000\.000\-00");                    
                    SGAP.Modelo.SGAPContexto contexto = new SGAPContexto();
                    cpf = txt.Text;
                    Consumidor cons = contexto.Consumidor.ToList().FirstOrDefault(t => t.cpf.CompareTo(cpf) == 0);
                    if(cons != null)
                    {
                        MessageBox.Show("Este CPF já está cadastrado no sistema!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);                       
                        txt.Focus();
                        return false;                       
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            else
            {
                return true;
            }
        }

        public static bool tratamentoCpfConsumidorNoBd(TextBox txt)
        {
            if (txt.Text != "")
            {
                string cpf = txt.Text.Replace(".", "").Replace("-", "").Replace("/", "");

                if (ValidaCpf.IsCpf(txt.Text) != true)
                {
                    MessageBox.Show("CPF inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt.Focus();
                    return false;
                }
                else
                {
                    txt.Text = Convert.ToUInt64(cpf).ToString(@"000\.000\.000\-00");
                    return true;
                }
            }
            return true;
        }

        public static bool tratamentoCpnjFornecedor(TextBox txt)
        {
            if (txt.Text != "")
            {
                string cnpj = txt.Text.Replace(".", "").Replace("-", "").Replace("/", "");
                if (ValidaCpf.IsCnpj(txt.Text) != true)
                {
                    MessageBox.Show("CNPJ inválido", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt.Focus();
                    return false;
                }
                else
                {
                    txt.Text = Convert.ToUInt64(cnpj).ToString(@"00\.000\.000\/0000\.00");
                    SGAP.Modelo.SGAPContexto contexto = new SGAPContexto();
                    cnpj = txt.Text;
                    Fornecedor fornecedor = contexto.Fornecedor.ToList().FirstOrDefault(t => t.cnpj.CompareTo(cnpj) == 0);
                    if (fornecedor != null)
                    {
                        MessageBox.Show("Já existe um fornecedor cadastrado com este CNPJ!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt.Focus();
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            else
            {
                return true;
            }
        }

        public static bool tratamentoCpnjFornecedorNoBd(TextBox txt)
        {
            if (txt.Text != "")
            {
                string cnpj = txt.Text.Replace(".", "").Replace("-", "").Replace("/", "");
                if (ValidaCpf.IsCnpj(txt.Text) != true)
                {
                    MessageBox.Show("CNPJ inválido", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt.Focus();
                    return false;
                }
                else
                {
                    txt.Text = Convert.ToUInt64(cnpj).ToString(@"00\.000\.000\/0000\.00");
                    return true;
                }
            }
            else
            {
                return true;
            }
        }

    }    
}

