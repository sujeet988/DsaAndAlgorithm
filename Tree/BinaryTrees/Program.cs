// See https://aka.ms/new-console-template for more information
using BinaryTrees;

Console.WriteLine("Hello, World!");
int[] nodes =new int[] { 1, 2, 4, -1, -1, 5, -1, -1, 3, -1, 6, -1, -1 };
BinaryTree tree = new BinaryTree();

Node root = tree.buildTree(nodes);
tree.preOrder(root);
Console.WriteLine();
tree.inorder(root);
Console.WriteLine();
tree.postorder(root);

//Console.WriteLine(root.data);