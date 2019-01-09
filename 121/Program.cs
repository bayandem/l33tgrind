using System;

namespace _121
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
/*
public class Solution {
    public int LadderLength(string beginWord, string endWord, IList<string> wordList)
    {

        if(!wordList.Contains(beginWord))
            return 0;


        var ret = new List<string>();
        var que = new Queue<string>();


        addNeighbor(beginWord, que, wordList);
        ret.Add(beginWord);

        while(que.Count > 0)
        {
            var cur = que.Dequeue();

            if(wordList.Contains(cur))
            {
                addNeighbor(cur, que, wordList);
                wordList.Remove(cur);
            }
        }

        return ret.Contains(endWord) ? ret.Count : 0;
    }

    private void addNeighbor(string current, Queue<string> queue, IList<string> list)
    {

        foreach(var word in list)
        {
            if(current.Except(word).Count() == 1)
            {
                queue.Enqueue(word);
            }
        }
    }
}
 */
