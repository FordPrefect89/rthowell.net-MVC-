SELECT * FROM dbo.ReloadingLedger
WHERE Speed IS NULL;

INSERT INTO dbo.ReloadingData
(Cartridge, DateLoaded, LoadSource, BulletBrand, BulletType, BulletWeight, Powder, PowderWeight, PowderLot, PrimerBrand, PrimerType, PrimerLot, COL, Speed, Notes)
VALUES
(
'500 S&W',
CAST('2016-01-01' AS DATETIME),
'Hornady',
'Berrys',
'Round Shoulder',
350,
'IMR 4227',
42.5,
'1011516A507',
'Winchester',
'WLR',
'KML170G',
'2.100"',
0,
'This was the max load in the Hornaday book for HNDY Bullet of same weight.  Berrys Bullet does not seat to canallure.  Moved to Speer book for load data with better results.'
);

UPDATE dbo.ReloadingLedger
SET Speed=0
WHERE Speed IS NULL;
select * from dbo.ReloadingLedger;

INSERT INTO dbo.ReloadingData
(Cartridge, DateLoaded, LoadSource, BulletBrand, BulletType, BulletWeight, Powder, PowderWeight, PrimerBrand, PrimerType, COL, Speed, Notes)
VALUES
(
'9mm Luger',
CAST('2016-05-29' AS DATETIME),
'Lyman',
'Berrys',
'Round Nose',
147,
'TiteGroup',
3.6,
'CCI',
'Small Pistol #500',
'1.130"',
NULL,
'Load Workup.  Primer Lot# A22X4.  Powder Lot# 10329162576.'
);

select * from dbo.ReloadingData

DELETE FROM dbo.ReloadingData
WHERE Id=2

INSERT INTO dbo.ReloadingData
SELECT * FROM dbo.ReloadingLedger;