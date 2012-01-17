/*
 * Copyright 2008 ZXing authors
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;

namespace com.google.zxing.common
{
   public sealed class SummaryResults
   {
      private int totalFound;
      private int totalMustPass;
      private int totalTests;

      public SummaryResults()
      {
         totalFound = 0;
         totalMustPass = 0;
         totalTests = 0;
      }

      public SummaryResults(int found, int mustPass, int total)
      {
         totalFound = found;
         totalMustPass = mustPass;
         totalTests = total;
      }

      public void Add(SummaryResults other)
      {
         totalFound += other.totalFound;
         totalMustPass += other.totalMustPass;
         totalTests += other.totalTests;
      }

      override public String ToString()
      {
         return "\nSUMMARY RESULTS:\n  Decoded " + totalFound + " images out of " + totalTests +
           " (" + (totalFound * 100 / totalTests) + "%, " + totalMustPass + " required)";
      }
   }
}
