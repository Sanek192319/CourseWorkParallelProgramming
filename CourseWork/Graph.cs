class Graph
{

    private int MAX_VERTS = 15000;
    private Vertex[] vertexList;
    private int[][] adjMat;
    private int nVerts;
    private Stack<int> s;

    public Graph()
    {
        adjMat = new int[MAX_VERTS][];
        for (int i = 0; i < MAX_VERTS; i++)
        {
            adjMat[i] = new int[MAX_VERTS];
        }
        //nVerts = 0;
        vertexList = new Vertex[MAX_VERTS];
        for (int i = 0; i < MAX_VERTS; i++)
        {
            addVertex();
        }
        s = new Stack<int>();
    }


    public void addVertex()
    {
        vertexList[nVerts++] = new Vertex(nVerts);
    }

    private void addEdge(int start, int end)
    {
        this.adjMat[start][end] = 1;
        this.adjMat[end][start] = 1;
    }

    public void displayVertex(int v)
    {
        Console.WriteLine($"{vertexList[v].label + " "}");
    }

    public int getAdjUnvisitedVertex(int v)
    {
        for (int j = 0; j < MAX_VERTS; j++)
        {
            if (adjMat[v][j] == 1 && vertexList[j].wasVisited == false)
            {
                return j;
            }
        }
        return -1;
    }

    public void dfs()
    {
        vertexList[0].wasVisited = true;
        //displayVertex(0);
        s.Push(0);

        while (s.Count != 0)
        {
            int v = getAdjUnvisitedVertex(s.Peek());

            if (v == -1)
            {
                s.Pop();
            }
            else
            {
                vertexList[v].wasVisited = true;
                //displayVertex(v);
                s.Push(v);
            }
        }
        Console.WriteLine("end");
    }
    public void PrintArray(int[][] arr, int size)
    {
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write($"{arr[i][j]} ");
            }
            Console.WriteLine();
        }

    }
    public int[][] CreateArray(int size, double possibility)
    {

        var rand = new Random();
        int[][] newmass = new int[size][];
        for (int i = 0; i < size; i++)
        {
            newmass[i] = new int[size];
        }
        for (int i = 0; i < size; i++)
        {
            for (int j = i + 1; j < size; j++)
            {
                if ((rand.Next(0, 100) >= (int)100 * possibility ? 1 : 0) == 1)
                {
                    addEdge(i, j);
                    //addVertex();
                    newmass[i][j] = 1;
                    newmass[j][i] = 1;
                }
                else
                {
                    newmass[i][j] = 0;
                    newmass[j][i] = 0;
                }
            }
        }
        //PrintArray(newmass, size);
        //for (int i = 0; i < size; i++)
        //{
        //    newmass[i][size - 1] = 0;
        //}
        //newmass[size - 2][size - 1] = 1;

        return newmass;
    }
}