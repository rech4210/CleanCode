# CleanCode

안녕하세요 이 문서는 클린코드 책을 공부하며 디자인 패턴과 객체지향 개념을 정리해놓은 문서입니다.

![image](https://user-images.githubusercontent.com/65288322/170859741-7a9598e2-dce7-41b8-9249-63eaf8ad68ce.png)


이 문서는 객체지향의 개념인 상속과 인터페이스를 활용한 구현이 포함되어 있습니다.

상속에서는 최상위 Abstract 클래스 Character.cs는 정보기능이 포함되어 있으며 이를 상속받은 Abstract 클래스 Aliance.cs와 Enemy.cs가 있습니다. 이 두 스크립트는 각각 아군과 적군을 생성하기 위한 팩토리 형식이며 아군 캐릭터, NPC를 Aliance.cs 에서 상속받아 제작합니다.

캐릭터는 독자적인 스킬을 갖고 있기에 이 부분은 Interface인 UseableSkills.cs를 implements하여 캐릭터를 제작합니다.

반대로, 적군 캐릭터는 스킬이 없기에 Interface를 사용하지 않도록 구현하였으며 대신 적에 따른 대사를 추가할수있게 Enemy.cs 스크립트를 상속받았습니다.

그 외 커플링을 낮추고 응집도를 높이기위해 만들어둔 test 스크립트에는 람다식, 제너릭, 델리게이트의 사용법과 사용 예시가 포함되어 있습니다.
