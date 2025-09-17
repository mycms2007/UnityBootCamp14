
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

//노드값이 어떻게 전달되는지,
//각 어미 노드가 각자의 트리를 가지고 있고 각자의 함수를 가진것처럼 보이지만,
//사실 한 번의 시행(노드입력)으로 전체에 퍼져나가는 흐름을 이해할 수 있었습니다.
//재귀적으로 자식은 다시 어미가 되어 자식에게 자신같은 InsertRec을 수행하도록함도 맞겠지만.
//시행은 한 번이라는 것을 알았습니다.
//이제 코드만 부지런히 익숙해지면 될 것 같습니다.