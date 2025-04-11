int numero = int.Parse(textBox1.Text);

if (numero % 3 == 0 && numero % 5 == 0)
{
    MessageBox.Show("O numero é diviser por 3 e por 5 ao mesmo tempo!");
}
else
{
    MessageBox.Show("O numero não é divisivel por 3 e 5 ao mesmo tempo");
}
