# Decorator-Pattern-Example-FPS-Prototype
Decorator Pattern ile basit bir weapon upgrade sisteminin oluşturulduğu bir FPS prototipini içeren repo'dur.<br><br>
Bu repo, daha önce geliştirilmiş olan FPS prototipinin 5.Versiyonudur(v5). Bu Readme'de sadece v5'te değiştirilen veya eklenen kısımlar açıklanacaktır.<br>
Diğer sınıfların açıklamaları için :<br>
v4 => https://github.com/Unitarian2/Subclass-Sandbox-Example <br>
v3 => https://github.com/Unitarian2/PickupableItemFactoryWithFlyweightPattern<br>
v2 => https://github.com/Unitarian2/BasicAdapterExample<br>
v1 => https://github.com/Unitarian2/ObserverPattern-MVP-Based-User-Interface<br><br>

<b>---BULLET---</b><br>
<b>BulletController.cs</b> => Silah ateş ettiğinde spawn edilen Bullet'ın logic'inin bulunduğu sınıftır. Bullet herhangi bir cisime çarptığında ilgili pool'a döner. <br>
<b>BulletFactory.cs</b> => Bullet'ların spawn edildiği Factory class'tır. Unity'nin Object Pooling sistemini kullanır.<br>
<b>BulletSettings.cs</b> => Bullet spawn işleminin Flyweight Pattern'e uygun şekilde gerçekleşmesi için bir Scriptable Object ile Settings yapısı kullanıyoruz.<br><br>

---PLAYERSCRIPTS---<br>
<b>ReceiveInteraction.cs</b> => Bu sınıf daha önceki versiyonlarda tanımlanmıştı. Bu versiyonda bu sınıfa OnTriggerEnter üzerinden WeaponUpgradePickupable pickup edilmesi işlemi eklendi.<br><br>

---WEAPONS---<br>
<b>BasicWeapon.cs</b> => Base Concrete silah sınıfıdır. Constructor üzerinden dependency alır, IWeapon interface'i üzerinden Fire metodunu tanımlar.<br>
<b>IWeapon.cs</b> => Silah sınıflarının soyutlandığı interface'dir.<br>
<b>WeaponUpgradeDefinition.cs</b> => Bu Scriptable Object ile farklı weapon upgrade'ler tanımlıyoruz.<br>
<b>WeaponDecorator.cs</b> => Base Weapon Decorator sınıfıdır. Concrete Decorator'lar bu sınıf üzerinden türetilir.<br>
<b>WDamageUpgrade.cs</b> => Weapon hasarını artıran upgrade'dir.<br>
<b>WRateOfFireUpgrade.cs</b> => Weapon atış hızını artıran upgrade'dir.<br>
<b>WeaponController.cs</b> => ReceiveInteraction_OnWeaponUpgradePickedUp metodu ile weapon upgrade item pickup edildiğinde Decorator sınıfları kullanılarak upgrade silaha uygulanır.<br>
<b>WeaponUpgradeController.cs</b> => Pickup edilen upgrade'lerin bir listesinin tutulduğu ve silahın görselinin güncellendiği bir sınıftır. Decorator pattern'e bir katkısı yoktur. Görsel amaçlı eklenmiştir.<br>
