# 버튼 잡기 게임 (C# 코딩)

## 개요
- 개발자 : 25017095 황규희
- C# 프로그래밍 학습
- 핵심기능: 버튼위에 마우스 올리면 도망가기, 버튼 올리면 커서 바뀌기, 마우스가 창 밖으로 안나가게 하기, 성공하면 성공메시지 나오기, 도망갈때 삐-소리 나기. 점수 계산 및 표시, 놓친 횟수가 30번 이상이면 게임 오버 및 버튼 비활성화 및 다시시작 버튼 등장. 다시시작 버튼 누르면 게임 재게(점수 및 놓친 횟수 초기화).
- 화면구성: "나를 잡아봐" 버튼. 폼 제목에서 현재 버튼 좌표 표시.


## 실행 화면
- 1단계 코드의 실행 스크린샷(버튼 도망가기 로직, 좌표 표시 구현)
<img width="999" height="589" alt="image" src="https://github.com/user-attachments/assets/d8f1db28-8109-4857-90c9-e73e6a1bbf55" />

- 2단계 코드의 실행 스크린샷(시각/청각 효과 구현)
<img width="793" height="585" alt="image" src="https://github.com/user-attachments/assets/049cbf0c-71bf-4d20-b7fb-5231bc20cb70" />

- 3단계 코드의 실행 스크린샷(점수 넣기)
<img width="725" height="552" alt="image" src="https://github.com/user-attachments/assets/11095766-1b51-437e-82f2-5486383d807e" />

- 4단계 코드의 실행 스크린샷(게임오버 구현)
<img width="1103" height="588" alt="image" src="https://github.com/user-attachments/assets/67172381-68e6-48e0-a6cc-20e728cfe43f" />

<img width="788" height="683" alt="image" src="https://github.com/user-attachments/assets/06b607e0-9081-4504-88c6-2958118353eb" />



## 구현 시 어려웠던 점
- 중간에 github에 푸시가 제대로 되지 않는 문제가 있었지만, 병합하고 다시 푸시하는 방식으로 해결한 것으로 보인다.  
- 폼 제목을 코드에서는 text로 표현한다는 사실을 알게되었다.
- 테스트용으로 깃허브에 올린 레포를 다시 다운받아 실행해본 결과, vs에서 폴더를 여는게 아니라 csproj나 slnx파일을 열어야 한다는 기가막힌 사실을 알아내었다. 
- 변수 이름을 막 지으니 약간 복잡해지는것 같아서, 버튼의 역할에 맞게 이름을 적절하게 설정(ex : 버튼 이름을 myTarget으로 하기)하는 것도 중요하다는걸 배웠다.

## 추신
 - 드디어 다 됐다 할렐루야
