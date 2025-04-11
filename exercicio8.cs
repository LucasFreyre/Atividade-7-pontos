int vitoria = int.Parse(textBox1.Text);
int empate = int.Parse(textBox2.Text);
int derrota = int.Parse(textBox3.Text);
int feitos = int.Parse(textBox4.Text);
int sofridos = int.Parse(textBox5.Text);

int jogos = vitoria + empate + derrota;
float mediafeita = feitos / jogos;
float mediasofrido = sofridos / jogos;
float porcentagemvitoria = vitoria * 100 / jogos;
float porcentagemempate = empate * 100 / jogos;
float porcentagemderrota = derrota * 100 / jogos;
int pontos1 = vitoria * 3;
int pontos2 = empate * 1;
int pontototais = pontos2 + pontos1;
int saldo = feitos - sofridos;
MessageBox.Show("A quantidade de pontos que seu time pontuou foi " + pontototais + ", O seu saldo de gols foi " + saldo + ", A sua porcentagem de vitorias foi " 
    + porcentagemvitoria +
    ", A sua porcentagem de empate foi " + porcentagemempate + ", A sua porcentagem de derrota foi " + porcentagemderrota 
    + ", A sua media de gols feitos por partida foi de " + mediafeita + ", A sua media de gols sofridos por partida foi de " + mediasofrido);
