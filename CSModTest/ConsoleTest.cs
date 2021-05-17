/*
 
CitizenManager Cman = CitizenManager.instance;
int expectedCitizenCount = Cman.m_citizenCount;
uint[] cid = new uint[expectedCitizenCount];
int CitizenCount = 0;
Citizen.Flags flagMask =Citizen.Flags.Created;
Citizen.Flags? expectedResult = null;
for (uint i = 0; i < Cman.m_citizens.m_buffer.GetUpperBound(0); i++)
{
    Citizen.Flags result = CitizenManager.instance.m_citizens.m_buffer[i].m_flags
                & flagMask;
    if (expectedResult == null ? result != 0 : result == expectedResult) { cid[CitizenCount] = i; CitizenCount++; }
}

Debug.Log("Citizen counted  =" + CitizenCount);
Debug.Log("Expected Citizen  =" + expectedCitizenCount);

*/
