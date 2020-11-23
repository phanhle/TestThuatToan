
namespace TestThuatToan
{
    public class Bai1 {
        public int CountSquare(int N){
            int count = 0;
            for(int i = 0; i <= N; i++){
                int j = 1;
                int countRow = 0;
                while(i + j <= N) {
                    countRow++;
                    j++;
                }
                count += countRow * countRow;
            }
            // return N*(N+1)*(2*N+1)/6;
            return count;
        }
    }
    
}