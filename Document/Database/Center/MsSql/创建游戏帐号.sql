/*
参数:
$loginPass 游戏中使用数据库登录账号(game_user)的密码
*/

CREATE LOGIN [$(gameuser)] WITH PASSWORD=N'$(loginPass)', DEFAULT_DATABASE=[master], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
go