﻿using System;

namespace Prime.Services
{
  public class PrimeService
  {
    public bool IsPrime(int candidate)
    {
      if (candidate == 1)
      {
        return false;
      }
      if (candidate == 7)
      {
        return true;
      }
      throw new NotImplementedException("Please create a test first.");
    }
  }
}
