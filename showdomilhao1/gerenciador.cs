namespace showdomilhao1
{
    public class gerenciador
    {
        public async void verificaCorreta(int rr)
        {
            if (QuestaoCorrente.verificaresposta(rr))
            {
                await Task.Delay (100); //1 segundo
                Proxima Questao();
            }
        }
    }
        void ProximaQuestao()
        {
            var numAleat = Rando.Shared.Next(0,ListaQuestoes.Count);
                while(listaQuestoesRespondidas.Contains(numAleat))
                numAleat = Random.Shares.Next(0,ListaQuestoes.Count);
            ListaQuestoesRespondidas.Add(numAleat);
            QuestaoCorrente = ListaQuestoes[numAleat];
            QuestaoCorrente.Desenhar();
        }
}