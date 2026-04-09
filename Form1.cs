namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        // 총 금액 변수
        int totalCost = 0;

        public Form1()
        {
            InitializeComponent();
        }

        // [핵심] 실시간 계산 및 화면 업데이트 메서드
        private void UpdateOrderInfo()
        {
            // 1. 변수 및 UI 초기화
            totalCost = 0;
            lstOrder.Items.Clear();

            // 2. 메뉴 가격 계산 (RadioButton)
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

            // 3. 추가 옵션 가격 계산 (CheckBox)
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
            lblTotalCost.Text = "총 금액 : " + totalCost.ToString("N0") + "원";

            // 메뉴가 하나라도 선택되면 에러 메시지 숨김
            if (rdoHam.Checked || rdoBul.Checked || rdoChi.Checked)
            {
                lblError.Visible = false;
                lblError.Text = "";
            }
        }

        // '주문하기' 버튼: 이제는 입력 검증 위주로 동작
        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (!rdoHam.Checked && !rdoBul.Checked && !rdoChi.Checked)
            {
                lblError.Text = "메뉴를 선택하세요.";
                lblError.Visible = true;
                return;
            }

            // 이미 UpdateOrderInfo에서 계산이 되었겠지만, 확정을 위해 호출
            UpdateOrderInfo();
            MessageBox.Show("주문이 완료되었습니다!");
            rdoHam.Focus();
        }

        // 초기화 버튼
        private void btnClear_Click(object sender, EventArgs e)
        {
            rdoHam.Checked = false;
            rdoBul.Checked = false;
            rdoChi.Checked = false;
            chkPotato.Checked = false;
            chkCola.Checked = false;
            chkCheese.Checked = false;
            chkSauce.Checked = false;

            lstOrder.Items.Clear();
            lblTotalCost.Text = "총 금액 : 0원";
            lblError.Visible = false;
            rdoHam.Focus();
        }

        // 컨트롤들의 값이 바뀔 때마다 실행될 이벤트 메서드
        private void OrderControl_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrderInfo();
        }
    }
}