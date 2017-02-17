

<?php
	 $n=readline("Enter the number of rows");
	 readline_add_history($n);
     $space = 1;
    
   
    
    $space = $n - 1;
    
    for ($k = 1; $k <= $n; $k++)
    {
    
        for ($c = 1; $c <= $space; $c++)
        print(" ");
        
        $space--;
        
        for ($c = 1; $c <= 2*$k-1; $c++)
        print("*");
        
        print("\n");    
    
    }    
    $space = 1;
    
    for ($k = 1; $k <= $n - 1; $k++)
    {
    
        for ($c = 1; $c <= $space; $c++)
        print(" ");
        
        $space++;
        
        for ($c = 1 ; $c <= 2*($n-$k)-1; $c++)
        print("*");
        
        print("\n");    
        
    }
    
 ?>