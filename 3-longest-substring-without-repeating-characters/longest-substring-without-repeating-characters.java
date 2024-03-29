class Solution {
    public int lengthOfLongestSubstring(String s) {
       int tamanhoTexto = s.length();
        int indiceEsquerdo = 0, indiceDireito = 0;
        int[] ultimaPosicaoCaractere = new int[128]; 
        Arrays.fill(ultimaPosicaoCaractere, -1); 

        int tamanhoSubstrMaior = 0;
        while (indiceDireito < tamanhoTexto) {
            int indiceAnterior = ultimaPosicaoCaractere[s.charAt(indiceDireito)];

            if (indiceAnterior >= indiceEsquerdo) { 
                indiceEsquerdo = indiceAnterior + 1; 
            } else {
                tamanhoSubstrMaior = Math.max(tamanhoSubstrMaior, indiceDireito - indiceEsquerdo + 1); 
            }

            ultimaPosicaoCaractere[s.charAt(indiceDireito)] = indiceDireito; 
            indiceDireito++;
        }

        return tamanhoSubstrMaior;
    }
}
