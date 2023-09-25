# project1
WPF

## 01 
- mah:MetroWindow  사용
- 메인화면
  - 메뉴바
  - ContentControl
- 기록 입력하기 화면
  - 해야할 것 : db 연동 및 db 만들기
- 기록조회하기 화면
  - 해야할 것 : db 연동 및 db 만들기
- 무게 화면
  - 해야할 것 : 계산기 완성하기
  
## 02
- 계산기 (팝업창처럼 main화면 위에 뜨게 만들었어요)
  - calculator2으로 작업했어요
  - clear 버튼 클릭 시 다 지워지게 만들기 (o)
  - 숫자 누르면 tbxMemo에 출력되게 만들기 (o)
  - 연산자 누르면 tbxMemo에 출력되게 만들기 (ㅁ)
    - 숫자 뒤에 나오기 하지만 연산자 뒤에 숫자 클릭 시 앞에 출력되었던 부분이 삭제됨
  - 결과 출력하기 (ㅁ)
    - 처음 입력한 숫자는 저장이 되지 않는 것 같음
    - 애매하게 결과가 출력되기는 하지만 다시 정리 필요

## 03
- 운동 -> 설명부분 디자인 시작
  - 운동 검색할 수 있는 TextBox
  - 검색 버튼
  - 검색 버튼 클릭 시 Youtube 연동하여 해당 운동 검색되어 영상 나올 수 있게 만들 예정

## 04
- 운동 설명 부분
  - YouTube연동시 CefSharp 누겟 사용했었는데 설치가 안돼 연동해보지 못함
- 대회 만들기 화면 디자인 시작
  - 대회명, 참가자 이름, 참가자 생년월일, 참가자 휴대폰 번호 입력 칸 만들기
  - 확인 버튼 클릭 시 popup창 혹은 옆에 표하나 더 만들어서 확인 한 뒤 저장할 수 있게 만들기

## 05
- 대회 만들기 화면
  - 처음에 mah 사용하기 위해 page를 이용하였으나 usercontrol이 아닌이유 때문인지 main화면에 나오지 않는 문제 발생
  - 다시 usercontrol로 변경
  - mah 사용하려 했던 이유
    - watermark 사용하고 싶었기 때문
  - mah 사용하지 않고 watermark 표시할 수 있는 방법을 찾아야 했음
    - textblock과 textbox 2개를 동시에 한 그리드에 넣는 방법응 이용하여 구현
      - 기본 설정
        - textbox background={x:null}
        - textblock Text="원하는 문구", Foreground = "Gray"(watermark 느낌 내기 위함)
      - textbox
        - TextChanged, LostFocus, GotFocus 이벤트 넣기 
      - TextChanged
        - textbox의 텍스트가 빈값일 경우 TextBlock.visibility = Visibility.Visible 해주기
        - 아닐경우 TextBlock.Visibility = Visibility.Hidden 해주기
      - LostFocus
        - TextBlock.Visibility = Visibility.Hidden 해주기
      - GotFoucus
        - textbox의 텍스트가 빈값일 경우 TextBlock.visibility = Visibility.Visible 해주기

## 06
- 대회만들기 화면
  - 확인, 취소 버튼 추가 (완료)
    - 기능 추가 아직 시작 안함
  - 참가자 정보 적는 부분 추가 (완료)

- 고민 중인 부분
  - 대회만들기에서 정말 대회만 만들고 참가자 정보는 오른쪽 화면에서 입력할 수 있도록 하는게 맞을지 고민 => 대회정보, 대회 참여자 정보 분리 입력 필요?
  - 참가자 정보만 적을 경우 대회명, 대회 정보 등을 가져 올 수 있는 db, 콤보박스 등이 필요할 것으로 예상됨
  - 참가자가 참가하지 않겟다고 이야기하는 경우 삭제하는 부분도 필요
  - 대회 참가자 확인 => 대회 정보에서 확인 할 수 있도록 할 예정(?) => 참가자 정보 부분 따로 안만들 경우
  - 확인 버튼 클릭시 오른쪽 화면에 저장할 내용 출력되고 확인 할 수 있도록 만들기
  - 

## 07
- 대회만들기 화면
  - 대회 정보 입력하기와 참가자 정보 입력하기 분리함
  - 대회 만들기 화면 load시 참가자 정보 입력하는 부분 visibility.Hidden 설정해놓음
  - 대회 정보 입력 후 확인버튼 클릭시 참가자 정보 입력하는 부분의 visibility = visible
  - 대회 정보 입력 취소 버튼 클릭시 참가자 정보 입력하는 부분 visibility = Hidden
-해야할 일
  - 대회정보 입력 후 확인버튼 클릭시 대회 정보(대회명, 시작날짜, 종료 날짜 db 넣는 작업 필요)
  - 대회정보 입력 후 확인버튼 클릭시 대회명 참가자정보의 대회명에 바인딩 하기 작업 필요

## 08
