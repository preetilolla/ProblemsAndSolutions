class LinkedList
{
    Node sortedMerge(Node headA, Node headB) {
     Node c1 = headA;
     Node c2 = headB;
     Node c3 = null;
     Node headC = null;
     
     // Base cases
     if(headA == null)
     {
         return headB;
     }
     if(headB == null)
     {
         return headA;
     }
     while(c1 != null && c2 != null)
     {
         if(c1.data > c2.data)
         {
             if(headC == null)
             {
                 headC = c2;
                 c3 = headC;
             }
             else
             {
                 c3.next = c2;
                 c3 = c3.next;
             }
             c2 = c2.next;
         }
         else
         {
             if(headC == null)
             {
                 headC = c1;
                 c3 = headC;
             }
             else
             {
                 c3.next = c1;
                 c3 = c3.next;
             }
             c1 = c1.next;
         }
     }
     if(c1 != null)
     {
         c3.next = c1;
     }
     if(c2 != null)
     {
         c3.next = c2;
     }
     return headC;
   } 
}
