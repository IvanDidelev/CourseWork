namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsEncodedStringNotSame()
        {
            string testString = "���";

            Assert.IsTrue(GetCodedString(testString) != testString);
        }

        [TestMethod]
        public void IsEncodedStringLengthSame()
        {
            string testString = "���";

            Assert.IsTrue(GetCodedString(testString).Length == testString.Length);
        }

        private string GetCodedString(string uncoded)
        {
            int nomer; // ����� � ��������
            int d; // ��������
            string s; //���������
            int j; // ���������� ��� ������

            char[] massage = uncoded.ToCharArray(); // ���������� ������ � ������ ��������.

            char[] alfavit = { '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�' };

            // ���������� ������ ������ ���������
            for (int i = 0; i < massage.Length; i++)
            {
                // ���� ������ �����
                for (j = 0; j < alfavit.Length; j++)
                {
                    if (massage[i] == alfavit[j])
                    {
                        break;
                    }
                }

                if (j != 33) // ���� j ����� 33, ������ ������ �� �� ��������
                {
                    nomer = j; // ������ �����
                    d = nomer + 3; // ������ ��������

                    // ���������, ����� �� ����� �� ������� ��������
                    if (d > 32)
                    {
                        d = d - 33;
                    }

                    massage[i] = alfavit[d]; // ������ �����
                }
            }

            return new string(massage); // �������� ������� ������� � ������.
        }
    }
}