namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        int totalCost = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            totalCost = 0;
            lstOrder.Items.Clear();

            // 2. 메뉴 선택 처리 (RadioButton)
            // 라디오버튼은 그룹 내 하나만 선택되므로 if-else if 구조가 적합합니다.
            if (rdoHam.Checked)
            {
                totalCost += 5000;
                lstOrder.Items.Add("햄버거 5,000원");
            }
            else if (rdoBul.Checked)
            {
                totalCost += 4000;
                lstOrder.Items.Add("불고기버거 4,000원");
            }
            else if (rdoChi.Checked)
            {
                totalCost += 3000;
                lstOrder.Items.Add("치킨버거 3,000원");
            }

            // 3. 추가 옵션 처리 (CheckBox)
            // 체크박스는 복수 선택이 가능하므로 각각 독립적인 if문을 사용합니다.
            if (chkPotato.Checked)
            {
                totalCost += 3500;
                lstOrder.Items.Add("감자튀김 3,500원");
            }
            if (chkCola.Checked)
            {
                totalCost += 2500;
                lstOrder.Items.Add("콜라 2,500원");
            }
            if (chkCheese.Checked)
            {
                totalCost += 1500;
                lstOrder.Items.Add("치즈 추가 1,500원");
            }
            if (chkSauce.Checked)
            {
                totalCost += 500;
                lstOrder.Items.Add("소스 추가 500원");
            }

            // 4. 결과 출력
            lblTotalCost.Text = "총 금액 : " + totalCost.ToString() + "원";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rdoHam.Checked = false;
            rdoBul.Checked = false;
            rdoChi.Checked = false;
            chkPotato.Checked = false;
            chkCola.Checked = false;
            chkCheese.Checked = false;
            chkSauce.Checked = false;

            // 리스트박스 및 결과 레이블 초기화
            lstOrder.Items.Clear();
            lblTotalCost.Text = "총 금액 : 0원";
        }
    }
}
