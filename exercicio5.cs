double altura = double.Parse(textBox1.Text);
double peso = double.Parse(textBox2.Text);

double imc = peso / Math.Pow(altura, 2);
MessageBox.Show("O IMC é: " + imc);
