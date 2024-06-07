public class Solution {
    public bool IsPathCrossing(string path) {
        List<(int, int)> visitedPositions = new List<(int, int)>();

        int x = 0;
        int y = 0;

        visitedPositions.Add((x, y));

        for (int i = 0; i < path.Length; i++) {
            char direction = path[i];

            if (direction == 'N') {
                y += 1; 
            }
            else if (direction == 'S') {
                y -= 1;
            }
            else if (direction == 'E') {
                x += 1; 
            }
            else if (direction == 'W') {
                x -= 1; 
            }

            foreach (var position in visitedPositions) {
                if (position == (x, y)) {
                    return true;
                }
            }

            visitedPositions.Add((x, y));
        }

        return false;
    }
}