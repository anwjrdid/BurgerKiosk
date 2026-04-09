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
            // 1. 입력 검증 (에러 메시지 처리)
            // 모든 라디오버튼이 체크되지 않았는지 확인합니다.
            if (!rdoHam.Checked && !rdoBul.Checked && !rdoChi.Checked)
            {
                // 에러 메시지 라벨에 문구 표시 (ForeColor는 빨간색으로 설정 권장)
                lblError.Text = "메뉴를 선택하세요.";
                lblError.Visible = true;

                // 메뉴를 선택하지 않았으므로 여기서 함수 실행을 종료합니다.
                return;
            }
            else
            {
                // 메뉴가 정상적으로 선택되었다면 에러 메시지를 지웁니다.
                lblError.Text = "";
                lblError.Visible = false;
            }

            // 2. 변수 및 UI 초기화
            // 계산을 시작하기 전 총 금액 변수를 0으로, 주문 내역 리스트를 비웁니다.
            int totalCost = 0;
            lstOrder.Items.Clear();

            // 3. 메뉴 가격 계산 (RadioButton - 단일 선택)
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

            // 4. 추가 옵션 가격 계산 (CheckBox - 복수 선택)
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

            // 5. 최종 결과 출력
            // 계산된 총 금액을 문자열로 변환하여 화면에 표시합니다.
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
