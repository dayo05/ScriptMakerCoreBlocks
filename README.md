# CoreBlocks Mod
## 렌더링 등에 대한 자세한 설명은 Custom Script의 readme를 확인해주세요.
## Tutorial
* 이 모드는 Script-Maker에 일반적으로 사용되는 블럭들을 추가합니다.
### Button Block
* 플레이어가 누를 수 있는 버튼을 추가합니다.
* 편집 창은 다음과 같습니다.
<img width="1512" alt="image" src="https://user-images.githubusercontent.com/77111795/211206397-0b3cbe23-3285-46ea-ac9e-4e7f779bd54c.png">

* 버튼의 좌상단 x, y 좌표, 버튼의 크기, 버튼에 들어갈 이미지를 설정합니다.
* 텍스트를 넣고 싶은 경우 이미지에 삽입하거나, 텍스트 블럭을 이용하여 따로 추가해야 합니다.
* Main 시점에 랜더링됩니다.
* 기본적으로 하나의 블럭은 하나의 화살표의 시작점으로만 지정이 가능하나, 화살표의 종료지점이 모두 Button Block인 경우는 이 규칙의 예외입니다. 이를 이용하여 분기로도 설정이 가능합니다.
<img width="1512" alt="image" src="https://user-images.githubusercontent.com/77111795/211206787-61a2dbfb-7a1f-4192-9215-6dc17085ce0f.png">

### Change Background Block
* GUI의 배경화면을 교체합니다.
* 편집 창은 다음과 같습니다.
<img width="1512" alt="image" src="https://user-images.githubusercontent.com/77111795/211206527-020e15f1-37ee-4c71-868a-de0e237594ed.png">

* 드롭다운에서 모드를 선택할 수 있습니다.
* Push모드는 하단의 박스에 입력된 이미지들을 엔터를 기준으로 Pre 시점에 랜더링하도록 추가합니다.
* Pop 모드는 가장 최근에 추가된 이미지 하나를 Pre 랜더링 리스트에서 제거합니다.
* Reset 모드는 Pre 랜더링 리스트를 초기화하고, 주어진 이미지들로 대체합니다.
### Delay Block
* 주어진 조건에 따라 GUI창의 진행을 막습니다.
* 편집 창은 다음과 같습니다.
<img width="1512" alt="image" src="https://user-images.githubusercontent.com/77111795/211206888-635ac0e1-deff-4558-81ca-7a735c602836.png">

* Delay Block은 3가지 대기 모드를 가집니다. Arrow 모드는 화살표 조건에 따라 대기합니다.(키 입력 대기) 이 내용은 0.8에서 변경 예정입니다.
* Time모드는 지정된 시간동안 대기합니다. 여기서 시간의 단위는 초입니다. ms미만의 단위는 제거됩니다.
* Video 모드는 아직 제작중이나, 현재 플레이중인 비디오 플레이가 완료된 경우 넘어가는 모드입니다.
### Run Command Block
* Run Command Block은 지정된 커멘드를 실행해 줍니다.
* 편집 창은 다음과 같습니다.
<img width="1512" alt="image" src="https://user-images.githubusercontent.com/77111795/211207067-f765f7bf-9899-4029-a137-5a03fa51075d.png">

* Client side로 설정할 경우, 플레이어가 해당 커맨드를 입력하게 됩니다.
* Server side로 실행할 경우, 서버 콘솔이 해당 커맨드를 입력하게 됩니다. 이 블럭은 보안의 문제로 인하여 기본적으로 서버 설정에서 사용이 불가능하도록 되있습니다. 해당 내용은 CustomScript의 설명을 참고해주세요. 저는 블럭의 이 모드 사용을 권장하지 않습니다.
### TextBlock
* GUI에 텍스트를 표시합니다.
* 편집 창은 다음과 같습니다.
<img width="1512" alt="image" src="https://user-images.githubusercontent.com/77111795/211206380-ee2c828c-7d70-4536-a771-ca9c78de1566.png">
