using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WindowsFormsApp1.CorreiosService;

namespace WindowsFormsApp1
{
    public partial class testNet : Form
    {


        private List<int> numeros = new List<int>(); // Lista para armazenar os números

        public testNet()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) //Apenas números
        {
            //aceitar apenas número na inputNumber
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        public void inputNumber_TextChanged(object sender, EventArgs e)
        {

        } //TextBox

        public void addNumber_Click(object sender, EventArgs e) //Botão Add
        {
            //Número Digitado
            string numeroDigitado = inputNumber.Text;

            // Converte o número para inteiro
            if (int.TryParse(numeroDigitado, out int numeroInt))
            {
                // Adiciona o número à lista
                numeros.Add(numeroInt);

                // Ordena a lista de números em ordem crescente
                numeros.Sort();

                // Atualiza o conteúdo da ListBox
                UpdateListBox();

                inputNumber.Clear();
            }
        }

        private void UpdateListBox()
        {
            // Limpa a ListBox
            listInput.Items.Clear();

            // Adiciona os números ordenados à ListBox
            foreach (int numero in numeros)
            {
                listInput.Items.Add(numero);
            }
        }//Update list

        private void listInput_SelectedIndexChanged(object sender, EventArgs e) //list
        {

        }

        public void txtGenerate_Click(object sender, EventArgs e) //Gera o txt
        {
            string nomeArquivo = "numeros_ordenar.txt";

            // Caminho completo do arquivo na pasta raiz da aplicação
            string caminhoCompleto = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, nomeArquivo);

            // Salva o conteúdo do ListBox no arquivo especificado
            File.WriteAllLines(caminhoCompleto, numeros.Select(n => n.ToString()));
            MessageBox.Show($"Arquivo '{nomeArquivo}' salvo com sucesso na pasta raiz da aplicação!");
        }

        private void openArchive_Click(object sender, EventArgs e)
        {
            string nomeArquivo = "numeros_ordenar.txt";
            string caminhoCompleto = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, nomeArquivo);
            Process.Start(caminhoCompleto);
        } //Abrir Arquivo     


        //Q3, Q4 e Q5
        public class clsTeste
        {
            public int Codigo { get; set; }
            public string Descricao { get; set; }
        }

        private void jsonGenerator_Click(object sender, EventArgs e)
        {
            List<clsTeste> lista = new List<clsTeste>();

            for (int i = 1; i <= 100; i++)
            {
                var novoObjeto = new clsTeste
                {
                    Codigo = i,
                    Descricao = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff")
                };
                lista.Add(novoObjeto);
            }

            string json = JsonConvert.SerializeObject(lista);
            File.WriteAllText("data.json", json);

            MessageBox.Show("A Lista data.json foi criada e salva com sucesso!");
        }

        private void loadGrid_Click(object sender, EventArgs e)
        {
            string json = File.ReadAllText("data.json");
            List<clsTeste> lista = JsonConvert.DeserializeObject<List<clsTeste>>(json);

            dataGridView.DataSource = lista;
        }

        //Q6
        private void inputCEP_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchCEP_Click(object sender, EventArgs e)
        {
            string cep = inputCEP.Text;

            try
            {
                using (var cliente = new AtendeClienteClient()) // Usando a classe gerada da referência
                {
                    var resposta = cliente.consultaCEP(cep);

                    if (resposta != null)
                    {
                        string enderecoFormatado =

                            $"  \"bairro\": \"{resposta.bairro}\"," + Environment.NewLine +
                            $"  \"cep\": \"{resposta.cep}\"," + Environment.NewLine +
                            $"  \"cidade\": \"{resposta.cidade}\"," + Environment.NewLine +
                            $"  \"uf\": \"{resposta.uf}\"," + Environment.NewLine +
                            $"  \"complemento\": \"{resposta.complemento2}\"," + Environment.NewLine +
                            $"  \"end\": \"{resposta.end}\",";
                        rtbAddress.Text = "{" + Environment.NewLine + enderecoFormatado + Environment.NewLine + "}";
                    }
                    else
                    {
                        rtbAddress.Text = "CEP não encontrado.";
                    }
                }
            }
            catch (System.ServiceModel.FaultException ex)
            {
                rtbAddress.Text = "Erro ao consultar CEP: " + ex.Message;
            }
            catch (System.Exception ex)
            {
                rtbAddress.Text = "Erro genérico: " + ex.Message;
            }
        }

        private void rtbAddress_TextChanged(object sender, EventArgs e)
        {

        }

        //q7

        public void dataGridViewBanks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void btnLoadBanks_Click(object sender, EventArgs e)
        {
            await LoadBanksDataAsync(); // Chame o método assíncrono
        }

        private async Task LoadBanksDataAsync() // Adicione o modificador async
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var response = await httpClient.GetStringAsync("https://brasilapi.com.br/api/banks/v1");
                    var banksData = JArray.Parse(response);

                    dataGridViewBanks.DataSource = banksData.ToObject<dynamic>();
                }
            }
            catch (System.Exception ex) // Use o namespace completo aqui
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            //Q7


        }



        private void btnDownloadAndShowImage_Click(object sender, EventArgs e)
        {
            DownloadAndShowImage();
        }
        private void DownloadAndShowImage()
        {
            string imageUrl = "https://redeservice.com.br/wp-content/uploads/2020/07/redeservice-logo.png";
            string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "redeservice-logo.png");

            try
            {
                using (WebClient webClient = new WebClient())
                {
                    webClient.DownloadFile(imageUrl, imagePath);
                }

                if (File.Exists(imagePath))
                {
                    byte[] imageBytes = File.ReadAllBytes(imagePath);
                    string base64Image = Convert.ToBase64String(imageBytes);

                    ShowImageInPictureBox(base64Image);
                }
            }
            catch (System.Exception ex) // Use o namespace completo aqui
            {
                MessageBox.Show("Erro ao fazer o download e exibir a imagem: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowImageInPictureBox(string base64Image)
        {
            try
            {
                byte[] imageBytes = Convert.FromBase64String(base64Image);
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    Image image = Image.FromStream(ms);
                    pictureBox.Image = image;

                    richTextBoxBase64.Text = base64Image;
                }
            }
            catch (System.Exception ex) // Use o namespace completo aqui
            {
                MessageBox.Show("Erro ao exibir a imagem: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
