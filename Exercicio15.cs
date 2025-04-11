int numero1 = int.Parse(textBox1.Text);
int numero2 = int.Parse(textBox2.Text);
int numero3 = int.Parse(textBox3.Text);

int numero = 0;

if (numero1 < numero2) {
    numero = numero1;
}
else
{
    numero = numero2;
}
if (numero3 < numero)
{
    numero = numero3;
}

MessageBox.Show("O menor numero é " + numero);
