using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSUniversalLib
{
    
    public class Calculation
    {
        public int GetQuantityForProduct(int productType, int materialType, int count, float width, float length)
        {
            int result = 0;
            float interimResult = 0;
            float area = width * length; ;

            if(area<0||count<0)
            {
                return -1;
            }

            switch(productType)
            {
                case 1:
                    {
                        interimResult = (float)(count * area * 1.1);
                        switch (materialType)
                        {
                            case 1:
                                {
                                    interimResult = (float)(interimResult * 1.003);
                                    result = (int)Math.Ceiling(interimResult);
                                    return result;
                                }
                            case 2:
                                {
                                    interimResult = (float)(interimResult  * 1.0012);
                                    result = (int)Math.Ceiling(interimResult);
                                    return result;
                                }
                            default:
                                {
                                    return -1;
                                }
                        }
                      
                    }
                case 2:
                    {
                        interimResult = (float)(count * area * 2.5);
                        switch (materialType)
                        {
                            case 1:
                                {
                                    interimResult = (float)(interimResult * 1.003);
                                    result = (int)Math.Ceiling(interimResult);
                                    return result;
                                }
                            case 2:
                                {
                                    interimResult = (float)(interimResult * 1.0012);
                                    result = (int)Math.Ceiling(interimResult);
                                    return result;
                                }
                            default:
                                {
                                    return -1;
                                }
                        }
                    }
                case 3:
                    {
                        interimResult = (float)(count * area * 8.43);
                        switch (materialType)
                        {
                            case 1:
                                {
                                    interimResult = (float)(interimResult * 1.003);
                                    result = (int)Math.Ceiling(interimResult);
                                    return result;
                                }
                            case 2:
                                {
                                    interimResult = (float)(interimResult * 1.0012);
                                    result = (int)Math.Ceiling(interimResult);
                                    return result;
                                }
                            default:
                                {
                                    return -1;
                                }
                        }
                    }
                default:
                    { 

                        return -1;
                    }
            }
        }
    }
}
