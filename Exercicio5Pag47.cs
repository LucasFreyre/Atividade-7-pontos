int matricula = int.Parse(textBox1.Text);
string matriculaS = matricula.ToString();
int horas = int.Parse(textBox2.Text);
char caracter = matriculaS[0];
int horasExtras = int.Parse(textBox3.Text);
double salario;
switch (caracter)
{
    case '1':
        if (horasExtras!=0)
        {
            salario = (((8 * 1.5) * horas) + horasExtras) - ((horas * 8)*0.11);
            MessageBox.Show("Seu salario bruto é " + salario);
        }
        else
        {
            salario = horas * 8;
            MessageBox.Show("Seu salario bruto é " + salario);
        }
        break;
    case '2':
        if (horasExtras != 0)
        {
            salario = (((10 * 1.5) * horas) + horasExtras) - ((horas * 10) * 0.11);
            MessageBox.Show("Seu salario bruto é " + salario);
        }
        else
        {
            salario = horas * 10;
            MessageBox.Show("Seu salario bruto é " + salario);
        }
        break;
    case '3':
        if (horasExtras != 0)
        {
            salario = (((12 * 1.5) * horas) + horasExtras) - ((horas * 12) * 0.11);
            MessageBox.Show("Seu salario bruto é " + salario);
        }
        else
        {
            salario = horas * 12;
            MessageBox.Show("Seu salario bruto é " + salario);
        }
        break;
    case '4':
        if (horasExtras != 0)
        {
            salario = (((15 * 1.5) * horas) + horasExtras) - ((horas * 15) * 0.11);
            MessageBox.Show("Seu salario bruto é " + salario);
        }
        else
        {
            salario = horas * 15;
            MessageBox.Show("Seu salario bruto é " + salario);
        }
        break;
    case '5':
        if (horasExtras != 0)
        {
            salario = (((20 * 1.5) * horas) + horasExtras) - ((horas * 20) * 0.11);
            MessageBox.Show("Seu salario bruto é " + salario);
        }
        else
        {
            salario = horas * 20;
            MessageBox.Show("Seu salario bruto é " + salario);
        }
        break;
