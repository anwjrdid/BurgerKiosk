using System;
using System.Windows.Forms;

namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        // 총 금액을 저장할 전역 변수
        int totalCost = 0;

        public Form1()
        {
            InitializeComponent();
        }

        // '주문하기' 버튼 클릭 이벤트 (Enter 키와 연동됨)
        private void btnOrder_Click(object sender, EventArgs e)
        {
            // 1. 입력 검증 (과제 2 내용)
            if (!rdoHam.Checked && !rdoBul.Checked && !rdoChi.Checked)
            {
                lblError.Text = "메뉴를 선택하세요.";
                lblError.Visible = true;
                return; // 메뉴 미선택 시 로직 종료
            }
            else
            {
                lblError.Text = "";
                lblError.Visible = false;
            }

            // 2. 변수 및 리스트박스 초기화
            totalCost = 0;
            lstOrder.Items.Clear();

            // 3. 메뉴 가격 계산 (RadioButton)
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

            // 4. 추가 옵션 가격 계산 (CheckBox)
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
            lblTotalCost.Text = "총 금액 : " + totalCost.ToString() + "원";

            // [과제 3] 주문 완료 후 다시 첫 번째 메뉴로 포커스 이동
            rdoHam.Focus();
        }

        // '초기화' 버튼 클릭 이벤트
        private void btnClear_Click(object sender, EventArgs e)
        {
            // 모든 선택 상태 해제
            rdoHam.Checked = false;
            rdoBul.Checked = false;
            rdoChi.Checked = false;

            chkPotato.Checked = false;
            chkCola.Checked = false;
            chkCheese.Checked = false;
            chkSauce.Checked = false;

            // 출력 컨트롤 및 에러 메시지 초기화
            lstOrder.Items.Clear();
            lblTotalCost.Text = "총 금액 : 0원";
            lblError.Visible = false;
            lblError.Text = "";

            // [과제 3] 초기화 후 첫 번째 메뉴로 포커스 이동
            rdoHam.Focus();
        }
    }
}