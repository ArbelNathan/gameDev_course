Queue<Node> q = new Queue<Node>();
q.Enqueue(root);
while(q.Count > 0)
{
    Node current = q.Dequeue();
    if(current == null)
        continue;
    q.Enqueue(current.Left);
    q.Enqueue(current.Right);

    DoSomething(current);
}