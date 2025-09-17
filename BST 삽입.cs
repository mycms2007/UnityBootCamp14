
private BstNode InsertRec(BstNode node, int key)
{
    if (node == null)
        return new BstNode(key);

    if (key < node.Key)
        node.Left = InsertRec(node.Left, key);
    else if (key > node.Key)
        node.Right = InsertRec(node.Right, key);

    return node;
}