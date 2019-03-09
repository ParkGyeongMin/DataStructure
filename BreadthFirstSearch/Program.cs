/*
 * node를 활용하여 너비우선탐색, 깊이우선 탐색 
 * Breadth -First Search ( BFS ) : 너비우선탐색
 * Depth - First Search ( DFS ) : 깊이 우선탐색 
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Xml.Xsl.Runtime;

namespace BreadthFirstSearch
{
    internal class Program
    {

        class Node
        {
            public Node left;
            public Node right;
            public String data;

            public Node(String data, Node left, Node right)
            {
                this.data = data;
                this.left = left;
                this.right = right;
            }

            public Node(String data)
            {
                this.data = data;
                this.left = null;
                this.right = null;
            }
        }

        static Node Tree()
        {
            Node root = new Node("A",
                new Node("B",
                    new Node("C"),new Node("D")),
                new Node("E",
                    new Node("F"), new Node("G",
                        new Node("H"), null)));
            return root;
        }


        static void bfs_traversal(Node node) // 너비우선탐색 
        {
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(node);

            while (q.Count > 0)
            {
                node = q.Dequeue();
                Console.Write(node.data + " ");
                
                if ( node.left != null)
                    q.Enqueue(node.left);
                
                if(node.right != null)
                    q.Enqueue(node.right);
            }
        }

        static void dfs_traversal(Node node) // 깊이우선탐색 
        {
            if (node == null)
                return;

            Console.Write(node.data + " ");
            dfs_traversal(node.left);
            dfs_traversal(node.right);
            
        }
        
        public static void Main(string[] args)
        {

            Node tree = Tree();

            Console.WriteLine("BFS --> "); bfs_traversal(tree);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("DFS --> "); dfs_traversal(tree);

        }
    }
}