using System;
using System.Collections.Generic;

public class media 
{
 public string title;
 public string classification;
 public string creator;
 public string genre;
 public int rating;
 public List<string> cocreator;
}

  
  
  
  
  
   public class movie : media
    {
        public int runtime;
        public string[] cast; 

    }
    

   public class album : media
    {
        public string[] runtime;
    
    }

   public class book : media
    {
        public int pages;
        public int[] bookmark;
        public int chapters;
        
    }
