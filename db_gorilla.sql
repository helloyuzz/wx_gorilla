/*
 Navicat Premium Data Transfer

 Source Server         : localhost
 Source Server Type    : MySQL
 Source Server Version : 80021
 Source Host           : localhost:3306
 Source Schema         : db_gorilla

 Target Server Type    : MySQL
 Target Server Version : 80021
 File Encoding         : 65001

 Date: 08/01/2021 18:12:54
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for movie
-- ----------------------------
DROP TABLE IF EXISTS `movie`;
CREATE TABLE `movie`  (
  `id` int(0) NOT NULL AUTO_INCREMENT,
  `Title` varchar(80) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `ReleaseDate` datetime(0) NULL DEFAULT NULL,
  `Genre` varchar(80) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `Price` decimal(10, 2) NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 3 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of movie
-- ----------------------------
INSERT INTO `movie` VALUES (1, 'aa', '2020-12-21 00:00:00', 'aa', 123.00);
INSERT INTO `movie` VALUES (2, 'asdfsadf', '2020-12-21 00:00:00', 'asdfasd', 123.00);
INSERT INTO `movie` VALUES (3, 'asdfasdf', '2020-12-21 00:00:00', 'sadfasdf', 123.00);

-- ----------------------------
-- Table structure for sm_city
-- ----------------------------
DROP TABLE IF EXISTS `sm_city`;
CREATE TABLE `sm_city`  (
  `id` int(0) NOT NULL AUTO_INCREMENT,
  `provinceid` int(0) NULL DEFAULT NULL,
  `city_name` varchar(80) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `show_index` int(0) NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 493 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of sm_city
-- ----------------------------
INSERT INTO `sm_city` VALUES (2, 1, '海淀区', 2);
INSERT INTO `sm_city` VALUES (3, 1, '通州区', 1);
INSERT INTO `sm_city` VALUES (4, 1, '房山区', 3);
INSERT INTO `sm_city` VALUES (5, 1, '丰台区', 7);
INSERT INTO `sm_city` VALUES (6, 1, '昌平区', 4);
INSERT INTO `sm_city` VALUES (7, 1, '大兴区', 5);
INSERT INTO `sm_city` VALUES (8, 1, '顺义区', 6);
INSERT INTO `sm_city` VALUES (9, 1, '朝阳区', 1);
INSERT INTO `sm_city` VALUES (10, 1, '西城区', 1);
INSERT INTO `sm_city` VALUES (11, 1, '延庆县', 1);
INSERT INTO `sm_city` VALUES (13, 1, '宣武区', 1);
INSERT INTO `sm_city` VALUES (14, 1, '怀柔区', 8);
INSERT INTO `sm_city` VALUES (15, 1, '崇文区', 9);
INSERT INTO `sm_city` VALUES (16, 1, '密云县', 10);
INSERT INTO `sm_city` VALUES (17, 1, '东城区', 11);
INSERT INTO `sm_city` VALUES (18, 1, '平谷区', 12);
INSERT INTO `sm_city` VALUES (19, 1, '门头沟区', 13);
INSERT INTO `sm_city` VALUES (20, 2, '和平区', 1);
INSERT INTO `sm_city` VALUES (21, 2, '北辰区', 2);
INSERT INTO `sm_city` VALUES (22, 2, '河北区', 3);
INSERT INTO `sm_city` VALUES (23, 2, '河西区', 4);
INSERT INTO `sm_city` VALUES (24, 2, '西青区', 5);
INSERT INTO `sm_city` VALUES (25, 2, '津南区', 6);
INSERT INTO `sm_city` VALUES (26, 2, '东丽区', 7);
INSERT INTO `sm_city` VALUES (27, 2, '武清区', 8);
INSERT INTO `sm_city` VALUES (28, 2, '宝坻区', 9);
INSERT INTO `sm_city` VALUES (29, 2, '红桥区', 10);
INSERT INTO `sm_city` VALUES (30, 2, '大港区', 11);
INSERT INTO `sm_city` VALUES (31, 2, '汉沽区', 12);
INSERT INTO `sm_city` VALUES (32, 2, '静海县', 13);
INSERT INTO `sm_city` VALUES (33, 2, '塘沽区', 14);
INSERT INTO `sm_city` VALUES (34, 2, '宁河县', 15);
INSERT INTO `sm_city` VALUES (35, 2, '蓟县', 16);
INSERT INTO `sm_city` VALUES (36, 2, '南开区', 17);
INSERT INTO `sm_city` VALUES (37, 2, '河东区', 18);
INSERT INTO `sm_city` VALUES (44, 3, '石家庄市', 1);
INSERT INTO `sm_city` VALUES (45, 3, '唐山市', 2);
INSERT INTO `sm_city` VALUES (46, 3, '保定市', 3);
INSERT INTO `sm_city` VALUES (47, 3, '邯郸市', 4);
INSERT INTO `sm_city` VALUES (48, 3, '邢台市', 5);
INSERT INTO `sm_city` VALUES (49, 3, '河北区', 6);
INSERT INTO `sm_city` VALUES (50, 3, '沧州市', 7);
INSERT INTO `sm_city` VALUES (51, 3, '秦皇岛市', 8);
INSERT INTO `sm_city` VALUES (52, 3, '张家口市', 9);
INSERT INTO `sm_city` VALUES (53, 3, '衡水市', 10);
INSERT INTO `sm_city` VALUES (54, 3, '廊坊市', 11);
INSERT INTO `sm_city` VALUES (55, 3, '承德市', 12);
INSERT INTO `sm_city` VALUES (56, 4, '太原市', 1);
INSERT INTO `sm_city` VALUES (57, 4, '大同市', 2);
INSERT INTO `sm_city` VALUES (58, 4, '运城市', 3);
INSERT INTO `sm_city` VALUES (59, 4, '长治市', 4);
INSERT INTO `sm_city` VALUES (60, 4, '晋城市', 5);
INSERT INTO `sm_city` VALUES (61, 4, '忻州市', 6);
INSERT INTO `sm_city` VALUES (62, 4, '临汾市', 7);
INSERT INTO `sm_city` VALUES (63, 4, '吕梁市', 8);
INSERT INTO `sm_city` VALUES (64, 4, '晋中市', 9);
INSERT INTO `sm_city` VALUES (65, 4, '阳泉市', 10);
INSERT INTO `sm_city` VALUES (66, 4, '朔州市', 11);
INSERT INTO `sm_city` VALUES (67, 5, '赤峰市', 1);
INSERT INTO `sm_city` VALUES (68, 5, '包头市', 2);
INSERT INTO `sm_city` VALUES (69, 5, '通辽市', 3);
INSERT INTO `sm_city` VALUES (70, 5, '呼和浩特市', 4);
INSERT INTO `sm_city` VALUES (71, 5, '鄂尔多斯市', 5);
INSERT INTO `sm_city` VALUES (72, 5, '乌海市', 6);
INSERT INTO `sm_city` VALUES (73, 5, '呼伦贝尔市', 7);
INSERT INTO `sm_city` VALUES (74, 5, '兴安盟', 8);
INSERT INTO `sm_city` VALUES (75, 5, '巴彦淖尔盟', 9);
INSERT INTO `sm_city` VALUES (76, 5, '乌兰察布盟', 10);
INSERT INTO `sm_city` VALUES (77, 5, '锡林郭勒盟', 11);
INSERT INTO `sm_city` VALUES (78, 5, '阿拉善盟', 12);
INSERT INTO `sm_city` VALUES (79, 6, '银川市', 1);
INSERT INTO `sm_city` VALUES (80, 6, '吴忠市', 2);
INSERT INTO `sm_city` VALUES (81, 6, '中卫市', 3);
INSERT INTO `sm_city` VALUES (82, 6, '石嘴山市', 4);
INSERT INTO `sm_city` VALUES (83, 6, '固原市', 5);
INSERT INTO `sm_city` VALUES (84, 7, '西宁市', 1);
INSERT INTO `sm_city` VALUES (85, 7, '海西州', 2);
INSERT INTO `sm_city` VALUES (86, 7, '海东地区', 3);
INSERT INTO `sm_city` VALUES (87, 7, '海北州', 4);
INSERT INTO `sm_city` VALUES (88, 7, '果洛州', 5);
INSERT INTO `sm_city` VALUES (89, 7, '玉树州', 6);
INSERT INTO `sm_city` VALUES (90, 7, '黄南藏族自治州', 7);
INSERT INTO `sm_city` VALUES (91, 8, '西安市', 1);
INSERT INTO `sm_city` VALUES (92, 8, '咸阳市', 2);
INSERT INTO `sm_city` VALUES (93, 8, '宝鸡市', 3);
INSERT INTO `sm_city` VALUES (94, 8, '汉中市', 4);
INSERT INTO `sm_city` VALUES (95, 8, '渭南市', 5);
INSERT INTO `sm_city` VALUES (96, 8, '安康市', 6);
INSERT INTO `sm_city` VALUES (97, 8, '榆林市', 7);
INSERT INTO `sm_city` VALUES (98, 8, '商洛市', 8);
INSERT INTO `sm_city` VALUES (99, 8, '延安市', 9);
INSERT INTO `sm_city` VALUES (100, 8, '铜川市', 10);
INSERT INTO `sm_city` VALUES (101, 9, '兰州市', 1);
INSERT INTO `sm_city` VALUES (102, 9, '天水市', 2);
INSERT INTO `sm_city` VALUES (103, 9, '庆阳市', 3);
INSERT INTO `sm_city` VALUES (104, 9, '武威市', 4);
INSERT INTO `sm_city` VALUES (105, 9, '酒泉市', 5);
INSERT INTO `sm_city` VALUES (106, 9, '张掖市', 6);
INSERT INTO `sm_city` VALUES (107, 9, '陇南地区', 7);
INSERT INTO `sm_city` VALUES (108, 9, '白银市', 8);
INSERT INTO `sm_city` VALUES (109, 9, '定西地区', 9);
INSERT INTO `sm_city` VALUES (110, 9, '平凉市', 10);
INSERT INTO `sm_city` VALUES (111, 9, '嘉峪关市', 11);
INSERT INTO `sm_city` VALUES (112, 9, '临夏回族自治州', 12);
INSERT INTO `sm_city` VALUES (113, 9, '金昌市', 13);
INSERT INTO `sm_city` VALUES (114, 9, '甘南州', 14);
INSERT INTO `sm_city` VALUES (115, 10, '乌鲁木齐市', 1);
INSERT INTO `sm_city` VALUES (116, 10, '五家渠市', 16);
INSERT INTO `sm_city` VALUES (117, 10, '博尔塔拉州', 15);
INSERT INTO `sm_city` VALUES (118, 10, '阿拉尔市', 14);
INSERT INTO `sm_city` VALUES (119, 10, '吐鲁番地区', 13);
INSERT INTO `sm_city` VALUES (120, 10, '阿勒泰州', 12);
INSERT INTO `sm_city` VALUES (121, 10, '和田地区', 11);
INSERT INTO `sm_city` VALUES (122, 10, '克拉玛依市', 10);
INSERT INTO `sm_city` VALUES (123, 10, '塔城地区', 9);
INSERT INTO `sm_city` VALUES (124, 10, '喀什地区', 8);
INSERT INTO `sm_city` VALUES (125, 10, '巴音郭楞州', 7);
INSERT INTO `sm_city` VALUES (126, 10, '阿克苏地区', 6);
INSERT INTO `sm_city` VALUES (127, 10, '哈密地区', 5);
INSERT INTO `sm_city` VALUES (128, 10, '石河子市', 4);
INSERT INTO `sm_city` VALUES (129, 10, '昌吉州', 3);
INSERT INTO `sm_city` VALUES (130, 10, '伊犁州', 2);
INSERT INTO `sm_city` VALUES (131, 10, '克孜勒苏州', 17);
INSERT INTO `sm_city` VALUES (132, 10, '图木舒克市', 18);
INSERT INTO `sm_city` VALUES (133, 11, '大连市', 1);
INSERT INTO `sm_city` VALUES (134, 11, '沈阳市', 2);
INSERT INTO `sm_city` VALUES (135, 11, '丹东市', 3);
INSERT INTO `sm_city` VALUES (136, 11, '辽阳市', 4);
INSERT INTO `sm_city` VALUES (137, 11, '葫芦岛市', 5);
INSERT INTO `sm_city` VALUES (138, 11, '锦州市', 6);
INSERT INTO `sm_city` VALUES (139, 11, '朝阳市', 7);
INSERT INTO `sm_city` VALUES (140, 11, '营口市', 8);
INSERT INTO `sm_city` VALUES (141, 11, '鞍山市', 9);
INSERT INTO `sm_city` VALUES (142, 11, '抚顺市', 10);
INSERT INTO `sm_city` VALUES (143, 11, '阜新市', 11);
INSERT INTO `sm_city` VALUES (144, 11, '盘锦市', 12);
INSERT INTO `sm_city` VALUES (145, 11, '本溪市', 13);
INSERT INTO `sm_city` VALUES (146, 11, '铁岭市', 14);
INSERT INTO `sm_city` VALUES (147, 12, '吉林市', 1);
INSERT INTO `sm_city` VALUES (148, 12, '长春市', 2);
INSERT INTO `sm_city` VALUES (149, 12, '白山市', 3);
INSERT INTO `sm_city` VALUES (150, 12, '延边州', 4);
INSERT INTO `sm_city` VALUES (151, 12, '白城市', 5);
INSERT INTO `sm_city` VALUES (152, 12, '松原市', 6);
INSERT INTO `sm_city` VALUES (153, 12, '辽源市', 7);
INSERT INTO `sm_city` VALUES (154, 12, '通化市', 8);
INSERT INTO `sm_city` VALUES (155, 12, '四平市', 9);
INSERT INTO `sm_city` VALUES (156, 13, '齐齐哈尔市', 1);
INSERT INTO `sm_city` VALUES (157, 13, '哈尔滨市', 2);
INSERT INTO `sm_city` VALUES (158, 13, '大庆市', 3);
INSERT INTO `sm_city` VALUES (159, 13, '佳木斯市', 4);
INSERT INTO `sm_city` VALUES (160, 13, '双鸭山市', 5);
INSERT INTO `sm_city` VALUES (161, 13, '牡丹江市', 6);
INSERT INTO `sm_city` VALUES (162, 13, '鸡西市', 7);
INSERT INTO `sm_city` VALUES (163, 13, '黑河市', 8);
INSERT INTO `sm_city` VALUES (164, 13, '绥化市', 9);
INSERT INTO `sm_city` VALUES (165, 13, '鹤岗市', 10);
INSERT INTO `sm_city` VALUES (166, 13, '伊春市', 11);
INSERT INTO `sm_city` VALUES (167, 13, '大兴安岭地区', 12);
INSERT INTO `sm_city` VALUES (168, 13, '七台河市', 13);
INSERT INTO `sm_city` VALUES (169, 14, '济南市', 1);
INSERT INTO `sm_city` VALUES (170, 14, '德州市', 15);
INSERT INTO `sm_city` VALUES (171, 14, '聊城市', 14);
INSERT INTO `sm_city` VALUES (172, 14, '东营市', 13);
INSERT INTO `sm_city` VALUES (173, 14, '滨州市', 12);
INSERT INTO `sm_city` VALUES (174, 14, '威海市', 11);
INSERT INTO `sm_city` VALUES (175, 14, '日照市', 10);
INSERT INTO `sm_city` VALUES (176, 14, '莱芜市', 16);
INSERT INTO `sm_city` VALUES (177, 14, '潍坊市', 9);
INSERT INTO `sm_city` VALUES (178, 14, '淄博市', 7);
INSERT INTO `sm_city` VALUES (179, 14, '烟台市', 6);
INSERT INTO `sm_city` VALUES (180, 14, '菏泽市', 5);
INSERT INTO `sm_city` VALUES (181, 14, '济宁市', 4);
INSERT INTO `sm_city` VALUES (182, 14, '临沂市', 3);
INSERT INTO `sm_city` VALUES (183, 14, '青岛市', 2);
INSERT INTO `sm_city` VALUES (184, 14, '泰安市', 8);
INSERT INTO `sm_city` VALUES (185, 14, '枣庄市', 17);
INSERT INTO `sm_city` VALUES (186, 15, '苏州市', 1);
INSERT INTO `sm_city` VALUES (187, 15, '徐州市', 2);
INSERT INTO `sm_city` VALUES (188, 15, '盐城市', 3);
INSERT INTO `sm_city` VALUES (189, 15, '无锡市', 4);
INSERT INTO `sm_city` VALUES (190, 15, '南京市', 5);
INSERT INTO `sm_city` VALUES (191, 15, '南通市', 6);
INSERT INTO `sm_city` VALUES (192, 15, '连云港市', 7);
INSERT INTO `sm_city` VALUES (193, 15, '常州市', 8);
INSERT INTO `sm_city` VALUES (194, 15, '镇江市', 9);
INSERT INTO `sm_city` VALUES (195, 15, '扬州市', 10);
INSERT INTO `sm_city` VALUES (196, 15, '淮安市', 11);
INSERT INTO `sm_city` VALUES (197, 15, '泰州市', 12);
INSERT INTO `sm_city` VALUES (198, 15, '宿迁市', 13);
INSERT INTO `sm_city` VALUES (199, 16, '松江区', 1);
INSERT INTO `sm_city` VALUES (200, 16, '长宁区', 17);
INSERT INTO `sm_city` VALUES (201, 16, '闸北区', 16);
INSERT INTO `sm_city` VALUES (202, 16, '普陀区', 15);
INSERT INTO `sm_city` VALUES (203, 16, '虹口区', 14);
INSERT INTO `sm_city` VALUES (204, 16, '杨浦区', 13);
INSERT INTO `sm_city` VALUES (205, 16, '黄浦区', 12);
INSERT INTO `sm_city` VALUES (206, 16, '闵行区', 11);
INSERT INTO `sm_city` VALUES (207, 16, '崇明县', 18);
INSERT INTO `sm_city` VALUES (208, 16, '静安区', 10);
INSERT INTO `sm_city` VALUES (209, 16, '奉贤区', 8);
INSERT INTO `sm_city` VALUES (210, 16, '浦东新区', 7);
INSERT INTO `sm_city` VALUES (211, 16, '青浦区', 6);
INSERT INTO `sm_city` VALUES (212, 16, '南汇区', 5);
INSERT INTO `sm_city` VALUES (213, 16, '嘉定区', 4);
INSERT INTO `sm_city` VALUES (214, 16, '金山区', 3);
INSERT INTO `sm_city` VALUES (215, 16, '宝山区', 2);
INSERT INTO `sm_city` VALUES (216, 16, '徐汇区', 9);
INSERT INTO `sm_city` VALUES (217, 16, '卢湾区', 19);
INSERT INTO `sm_city` VALUES (218, 17, '温州市', 1);
INSERT INTO `sm_city` VALUES (219, 17, '宁波市', 2);
INSERT INTO `sm_city` VALUES (220, 17, '杭州市', 3);
INSERT INTO `sm_city` VALUES (221, 17, '台州市', 4);
INSERT INTO `sm_city` VALUES (222, 17, '嘉兴市', 5);
INSERT INTO `sm_city` VALUES (223, 17, '金华市', 6);
INSERT INTO `sm_city` VALUES (224, 17, '湖州市', 7);
INSERT INTO `sm_city` VALUES (225, 17, '绍兴市', 8);
INSERT INTO `sm_city` VALUES (226, 17, '舟山市', 9);
INSERT INTO `sm_city` VALUES (227, 17, '丽水市', 10);
INSERT INTO `sm_city` VALUES (228, 17, '衢州市', 11);
INSERT INTO `sm_city` VALUES (229, 18, '芜湖市', 1);
INSERT INTO `sm_city` VALUES (230, 18, '池州市', 15);
INSERT INTO `sm_city` VALUES (231, 18, '亳州市', 14);
INSERT INTO `sm_city` VALUES (232, 18, '铜陵市', 13);
INSERT INTO `sm_city` VALUES (233, 18, '黄山市', 12);
INSERT INTO `sm_city` VALUES (234, 18, '宣城市', 11);
INSERT INTO `sm_city` VALUES (235, 18, '淮南市', 10);
INSERT INTO `sm_city` VALUES (236, 18, '巢湖市', 16);
INSERT INTO `sm_city` VALUES (237, 18, '淮北市', 9);
INSERT INTO `sm_city` VALUES (238, 18, '马鞍山市', 7);
INSERT INTO `sm_city` VALUES (239, 18, '安庆市', 6);
INSERT INTO `sm_city` VALUES (240, 18, '阜阳市', 5);
INSERT INTO `sm_city` VALUES (241, 18, '宿州市', 4);
INSERT INTO `sm_city` VALUES (242, 18, '六安市', 3);
INSERT INTO `sm_city` VALUES (243, 18, '合肥市', 2);
INSERT INTO `sm_city` VALUES (244, 18, '蚌埠市', 8);
INSERT INTO `sm_city` VALUES (245, 18, '滁州市', 17);
INSERT INTO `sm_city` VALUES (246, 19, '漳州市', 1);
INSERT INTO `sm_city` VALUES (247, 19, '厦门市', 2);
INSERT INTO `sm_city` VALUES (248, 19, '泉州市', 3);
INSERT INTO `sm_city` VALUES (249, 19, '福州市', 4);
INSERT INTO `sm_city` VALUES (250, 19, '莆田市', 5);
INSERT INTO `sm_city` VALUES (251, 19, '宁德市', 6);
INSERT INTO `sm_city` VALUES (252, 19, '三明市', 7);
INSERT INTO `sm_city` VALUES (253, 19, '南平市', 8);
INSERT INTO `sm_city` VALUES (254, 19, '龙岩市', 9);
INSERT INTO `sm_city` VALUES (255, 20, '南昌市', 1);
INSERT INTO `sm_city` VALUES (256, 20, '赣州市', 2);
INSERT INTO `sm_city` VALUES (257, 20, '上饶市', 3);
INSERT INTO `sm_city` VALUES (258, 20, '吉安市', 4);
INSERT INTO `sm_city` VALUES (259, 20, '九江市', 5);
INSERT INTO `sm_city` VALUES (260, 20, '新余市', 6);
INSERT INTO `sm_city` VALUES (261, 20, '抚州市', 7);
INSERT INTO `sm_city` VALUES (262, 20, '宜春市', 8);
INSERT INTO `sm_city` VALUES (263, 20, '景德镇市', 9);
INSERT INTO `sm_city` VALUES (264, 20, '萍乡市', 10);
INSERT INTO `sm_city` VALUES (265, 20, '鹰潭市', 11);
INSERT INTO `sm_city` VALUES (266, 21, '郑州市', 1);
INSERT INTO `sm_city` VALUES (267, 21, '许昌市', 16);
INSERT INTO `sm_city` VALUES (268, 21, '漯河市', 15);
INSERT INTO `sm_city` VALUES (269, 21, '三门峡市', 14);
INSERT INTO `sm_city` VALUES (270, 21, '濮阳市', 13);
INSERT INTO `sm_city` VALUES (271, 21, '驻马店市', 12);
INSERT INTO `sm_city` VALUES (272, 21, '焦作市', 11);
INSERT INTO `sm_city` VALUES (273, 21, '开封市', 10);
INSERT INTO `sm_city` VALUES (274, 21, '商丘市', 9);
INSERT INTO `sm_city` VALUES (275, 21, '周口市', 8);
INSERT INTO `sm_city` VALUES (276, 21, '平顶山市', 7);
INSERT INTO `sm_city` VALUES (277, 21, '信阳市', 6);
INSERT INTO `sm_city` VALUES (278, 21, '洛阳市', 5);
INSERT INTO `sm_city` VALUES (279, 21, '安阳市', 4);
INSERT INTO `sm_city` VALUES (280, 21, '新乡市', 3);
INSERT INTO `sm_city` VALUES (281, 21, '南阳市', 2);
INSERT INTO `sm_city` VALUES (282, 21, '鹤壁市', 17);
INSERT INTO `sm_city` VALUES (283, 21, '济源市', 18);
INSERT INTO `sm_city` VALUES (284, 22, '长沙市', 1);
INSERT INTO `sm_city` VALUES (285, 22, '邵阳市', 2);
INSERT INTO `sm_city` VALUES (286, 22, '常德市', 3);
INSERT INTO `sm_city` VALUES (287, 22, '衡阳市', 4);
INSERT INTO `sm_city` VALUES (288, 22, '株洲市', 5);
INSERT INTO `sm_city` VALUES (289, 22, '湘潭市', 6);
INSERT INTO `sm_city` VALUES (290, 22, '永州市', 7);
INSERT INTO `sm_city` VALUES (291, 22, '岳阳市', 8);
INSERT INTO `sm_city` VALUES (292, 22, '怀化市', 9);
INSERT INTO `sm_city` VALUES (293, 22, '郴州市', 10);
INSERT INTO `sm_city` VALUES (294, 22, '娄底市', 11);
INSERT INTO `sm_city` VALUES (295, 22, '益阳市', 12);
INSERT INTO `sm_city` VALUES (296, 22, '张家界市', 13);
INSERT INTO `sm_city` VALUES (297, 22, '湘西州', 14);
INSERT INTO `sm_city` VALUES (298, 23, '武汉市', 1);
INSERT INTO `sm_city` VALUES (299, 23, '潜江市', 15);
INSERT INTO `sm_city` VALUES (300, 23, '荆门市', 14);
INSERT INTO `sm_city` VALUES (301, 23, '随州市', 13);
INSERT INTO `sm_city` VALUES (302, 23, '天门市', 12);
INSERT INTO `sm_city` VALUES (303, 23, '仙桃市', 11);
INSERT INTO `sm_city` VALUES (304, 23, '黄石市', 10);
INSERT INTO `sm_city` VALUES (305, 23, '鄂州市', 16);
INSERT INTO `sm_city` VALUES (306, 23, '咸宁市', 9);
INSERT INTO `sm_city` VALUES (307, 23, '孝感市', 7);
INSERT INTO `sm_city` VALUES (308, 23, '黄冈市', 6);
INSERT INTO `sm_city` VALUES (309, 23, '恩施州', 5);
INSERT INTO `sm_city` VALUES (310, 23, '荆州市', 4);
INSERT INTO `sm_city` VALUES (311, 23, '襄樊市', 3);
INSERT INTO `sm_city` VALUES (312, 23, '宜昌市', 2);
INSERT INTO `sm_city` VALUES (313, 23, '十堰市', 8);
INSERT INTO `sm_city` VALUES (314, 23, '神农架林区', 17);
INSERT INTO `sm_city` VALUES (315, 24, '成都市', 1);
INSERT INTO `sm_city` VALUES (316, 24, '资阳市', 19);
INSERT INTO `sm_city` VALUES (317, 24, '宜宾市', 18);
INSERT INTO `sm_city` VALUES (318, 24, '雅安市', 17);
INSERT INTO `sm_city` VALUES (319, 24, '泸州市', 16);
INSERT INTO `sm_city` VALUES (320, 24, '自贡市', 15);
INSERT INTO `sm_city` VALUES (321, 24, '乐山市', 14);
INSERT INTO `sm_city` VALUES (322, 24, '攀枝花市', 13);
INSERT INTO `sm_city` VALUES (323, 24, '凉山州', 12);
INSERT INTO `sm_city` VALUES (324, 24, '眉山市', 20);
INSERT INTO `sm_city` VALUES (325, 24, '内江市', 11);
INSERT INTO `sm_city` VALUES (326, 24, '巴中市', 9);
INSERT INTO `sm_city` VALUES (327, 24, '阿坝州', 8);
INSERT INTO `sm_city` VALUES (328, 24, '广安市', 7);
INSERT INTO `sm_city` VALUES (329, 24, '德阳市', 6);
INSERT INTO `sm_city` VALUES (330, 24, '南充市', 5);
INSERT INTO `sm_city` VALUES (331, 24, '达州市', 4);
INSERT INTO `sm_city` VALUES (332, 24, '广元市', 3);
INSERT INTO `sm_city` VALUES (333, 24, '绵阳市', 2);
INSERT INTO `sm_city` VALUES (334, 24, '遂宁市', 10);
INSERT INTO `sm_city` VALUES (335, 24, '甘孜州', 21);
INSERT INTO `sm_city` VALUES (336, 25, '贵阳市', 1);
INSERT INTO `sm_city` VALUES (337, 25, '黔东南州', 2);
INSERT INTO `sm_city` VALUES (338, 25, '黔南州', 3);
INSERT INTO `sm_city` VALUES (339, 25, '遵义市', 4);
INSERT INTO `sm_city` VALUES (340, 25, '黔西南州', 5);
INSERT INTO `sm_city` VALUES (341, 25, '毕节地区', 6);
INSERT INTO `sm_city` VALUES (342, 25, '铜仁地区', 7);
INSERT INTO `sm_city` VALUES (343, 25, '安顺市', 8);
INSERT INTO `sm_city` VALUES (344, 25, '六盘水市', 9);
INSERT INTO `sm_city` VALUES (345, 26, '昆明市', 1);
INSERT INTO `sm_city` VALUES (346, 26, '红河州', 2);
INSERT INTO `sm_city` VALUES (347, 26, '大理州', 3);
INSERT INTO `sm_city` VALUES (348, 26, '文山州', 4);
INSERT INTO `sm_city` VALUES (349, 26, '德宏州', 5);
INSERT INTO `sm_city` VALUES (350, 26, '曲靖市', 6);
INSERT INTO `sm_city` VALUES (351, 26, '昭通市', 7);
INSERT INTO `sm_city` VALUES (352, 26, '楚雄州', 8);
INSERT INTO `sm_city` VALUES (353, 26, '保山市', 9);
INSERT INTO `sm_city` VALUES (354, 26, '玉溪市', 10);
INSERT INTO `sm_city` VALUES (355, 26, '丽江地区', 11);
INSERT INTO `sm_city` VALUES (356, 26, '临沧地区', 12);
INSERT INTO `sm_city` VALUES (357, 26, '思茅地区', 13);
INSERT INTO `sm_city` VALUES (358, 26, '西双版纳州', 14);
INSERT INTO `sm_city` VALUES (359, 26, '怒江州', 15);
INSERT INTO `sm_city` VALUES (360, 26, '迪庆州', 16);
INSERT INTO `sm_city` VALUES (361, 27, '江北区', 1);
INSERT INTO `sm_city` VALUES (362, 27, '潼南县', 23);
INSERT INTO `sm_city` VALUES (363, 27, '江津市', 24);
INSERT INTO `sm_city` VALUES (364, 27, '彭水县', 25);
INSERT INTO `sm_city` VALUES (365, 27, '綦江县', 26);
INSERT INTO `sm_city` VALUES (366, 27, '璧山县', 27);
INSERT INTO `sm_city` VALUES (367, 27, '黔江区', 28);
INSERT INTO `sm_city` VALUES (368, 27, '大足县', 29);
INSERT INTO `sm_city` VALUES (369, 27, '梁平县', 22);
INSERT INTO `sm_city` VALUES (370, 27, '巫山县', 30);
INSERT INTO `sm_city` VALUES (371, 27, '垫江县', 32);
INSERT INTO `sm_city` VALUES (372, 27, '丰都县', 33);
INSERT INTO `sm_city` VALUES (373, 27, '武隆县', 34);
INSERT INTO `sm_city` VALUES (374, 27, '万盛区', 35);
INSERT INTO `sm_city` VALUES (375, 27, '铜梁县', 36);
INSERT INTO `sm_city` VALUES (376, 27, '南川市', 37);
INSERT INTO `sm_city` VALUES (377, 27, '奉节县', 38);
INSERT INTO `sm_city` VALUES (378, 27, '巫溪县', 31);
INSERT INTO `sm_city` VALUES (379, 27, '云阳县', 21);
INSERT INTO `sm_city` VALUES (380, 27, '荣昌县', 20);
INSERT INTO `sm_city` VALUES (381, 27, '长寿区', 19);
INSERT INTO `sm_city` VALUES (382, 27, '渝北区', 2);
INSERT INTO `sm_city` VALUES (383, 27, '沙坪坝区', 3);
INSERT INTO `sm_city` VALUES (384, 27, '九龙坡区', 4);
INSERT INTO `sm_city` VALUES (385, 27, '万州区', 5);
INSERT INTO `sm_city` VALUES (386, 27, '永川市', 6);
INSERT INTO `sm_city` VALUES (387, 27, '南岸区', 7);
INSERT INTO `sm_city` VALUES (388, 27, '酉阳县', 8);
INSERT INTO `sm_city` VALUES (389, 27, '北碚区', 9);
INSERT INTO `sm_city` VALUES (390, 27, '涪陵区', 10);
INSERT INTO `sm_city` VALUES (391, 27, '秀山县', 11);
INSERT INTO `sm_city` VALUES (392, 27, '巴南区', 12);
INSERT INTO `sm_city` VALUES (393, 27, '渝中区', 13);
INSERT INTO `sm_city` VALUES (394, 27, '石柱县', 14);
INSERT INTO `sm_city` VALUES (395, 27, '忠县', 15);
INSERT INTO `sm_city` VALUES (396, 27, '合川市', 16);
INSERT INTO `sm_city` VALUES (397, 27, '大渡口区', 17);
INSERT INTO `sm_city` VALUES (398, 27, '开县', 18);
INSERT INTO `sm_city` VALUES (399, 27, '双桥区', 39);
INSERT INTO `sm_city` VALUES (400, 27, '城口县', 40);
INSERT INTO `sm_city` VALUES (401, 28, '拉萨市', 1);
INSERT INTO `sm_city` VALUES (402, 28, '山南地区', 2);
INSERT INTO `sm_city` VALUES (403, 28, '林芝地区', 3);
INSERT INTO `sm_city` VALUES (404, 28, '日喀则地区', 4);
INSERT INTO `sm_city` VALUES (405, 28, '阿里地区', 5);
INSERT INTO `sm_city` VALUES (406, 28, '昌都地区', 6);
INSERT INTO `sm_city` VALUES (407, 28, '那曲地区', 7);
INSERT INTO `sm_city` VALUES (408, 29, '东莞市', 1);
INSERT INTO `sm_city` VALUES (409, 29, '云浮市', 19);
INSERT INTO `sm_city` VALUES (410, 29, '梅州市', 18);
INSERT INTO `sm_city` VALUES (411, 29, '阳江市', 17);
INSERT INTO `sm_city` VALUES (412, 29, '揭阳市', 16);
INSERT INTO `sm_city` VALUES (413, 29, '韶关市', 15);
INSERT INTO `sm_city` VALUES (414, 29, '潮州市', 14);
INSERT INTO `sm_city` VALUES (415, 29, '清远市', 13);
INSERT INTO `sm_city` VALUES (416, 29, '肇庆市', 12);
INSERT INTO `sm_city` VALUES (417, 29, '茂名市', 20);
INSERT INTO `sm_city` VALUES (418, 29, '河源市', 11);
INSERT INTO `sm_city` VALUES (419, 29, '佛山市', 9);
INSERT INTO `sm_city` VALUES (420, 29, '汕头市', 8);
INSERT INTO `sm_city` VALUES (421, 29, '珠海市', 7);
INSERT INTO `sm_city` VALUES (422, 29, '江门市', 6);
INSERT INTO `sm_city` VALUES (423, 29, '惠州市', 5);
INSERT INTO `sm_city` VALUES (424, 29, '深圳市', 4);
INSERT INTO `sm_city` VALUES (425, 29, '中山市', 3);
INSERT INTO `sm_city` VALUES (426, 29, '广州市', 2);
INSERT INTO `sm_city` VALUES (427, 29, '湛江市', 10);
INSERT INTO `sm_city` VALUES (428, 29, '汕尾市', 21);
INSERT INTO `sm_city` VALUES (429, 30, '贵港市', 1);
INSERT INTO `sm_city` VALUES (430, 30, '玉林市', 2);
INSERT INTO `sm_city` VALUES (431, 30, '北海市', 3);
INSERT INTO `sm_city` VALUES (432, 30, '南宁市', 4);
INSERT INTO `sm_city` VALUES (433, 30, '柳州市', 5);
INSERT INTO `sm_city` VALUES (434, 30, '桂林市', 6);
INSERT INTO `sm_city` VALUES (435, 30, '梧州市', 7);
INSERT INTO `sm_city` VALUES (436, 30, '钦州市', 8);
INSERT INTO `sm_city` VALUES (437, 30, '来宾市', 9);
INSERT INTO `sm_city` VALUES (438, 30, '河池市', 10);
INSERT INTO `sm_city` VALUES (439, 30, '百色市', 11);
INSERT INTO `sm_city` VALUES (440, 30, '贺州市', 12);
INSERT INTO `sm_city` VALUES (441, 30, '崇左市', 13);
INSERT INTO `sm_city` VALUES (442, 30, '防城港市', 14);
INSERT INTO `sm_city` VALUES (443, 31, '三亚市', 1);
INSERT INTO `sm_city` VALUES (444, 31, '定安县', 16);
INSERT INTO `sm_city` VALUES (445, 31, '白沙县', 15);
INSERT INTO `sm_city` VALUES (446, 31, '临高县', 14);
INSERT INTO `sm_city` VALUES (447, 31, '儋州市', 13);
INSERT INTO `sm_city` VALUES (448, 31, '万宁市', 12);
INSERT INTO `sm_city` VALUES (449, 31, '澄迈县', 11);
INSERT INTO `sm_city` VALUES (450, 31, '五指山市', 10);
INSERT INTO `sm_city` VALUES (451, 31, '保亭县', 9);
INSERT INTO `sm_city` VALUES (452, 31, '乐东县', 8);
INSERT INTO `sm_city` VALUES (453, 31, '陵水县', 7);
INSERT INTO `sm_city` VALUES (454, 31, '昌江县', 6);
INSERT INTO `sm_city` VALUES (455, 31, '东方市', 5);
INSERT INTO `sm_city` VALUES (456, 31, '文昌市', 4);
INSERT INTO `sm_city` VALUES (457, 31, '琼海市', 3);
INSERT INTO `sm_city` VALUES (458, 31, '海口市', 2);
INSERT INTO `sm_city` VALUES (459, 31, '琼中县', 17);
INSERT INTO `sm_city` VALUES (460, 31, '屯昌县', 18);
INSERT INTO `sm_city` VALUES (461, 32, '中西区', 1);
INSERT INTO `sm_city` VALUES (462, 32, '元朗区', 16);
INSERT INTO `sm_city` VALUES (463, 32, '屯门区', 15);
INSERT INTO `sm_city` VALUES (464, 32, '荃湾区', 14);
INSERT INTO `sm_city` VALUES (465, 32, '西贡区', 13);
INSERT INTO `sm_city` VALUES (466, 32, '沙田区', 12);
INSERT INTO `sm_city` VALUES (467, 32, '大埔区', 11);
INSERT INTO `sm_city` VALUES (468, 32, '北区', 10);
INSERT INTO `sm_city` VALUES (469, 32, '观塘区', 9);
INSERT INTO `sm_city` VALUES (470, 32, '黄大仙区', 8);
INSERT INTO `sm_city` VALUES (471, 32, '九龙城区', 7);
INSERT INTO `sm_city` VALUES (472, 32, '深水埗区', 6);
INSERT INTO `sm_city` VALUES (473, 32, '油尖旺区', 5);
INSERT INTO `sm_city` VALUES (474, 32, '南区', 4);
INSERT INTO `sm_city` VALUES (475, 32, '东区', 3);
INSERT INTO `sm_city` VALUES (476, 32, '湾仔区', 2);
INSERT INTO `sm_city` VALUES (477, 32, '葵青区', 17);
INSERT INTO `sm_city` VALUES (478, 32, '离岛区', 18);
INSERT INTO `sm_city` VALUES (479, 33, '花地玛堂区', 1);
INSERT INTO `sm_city` VALUES (480, 33, '圣安多尼堂区', 2);
INSERT INTO `sm_city` VALUES (481, 33, '大堂区', 3);
INSERT INTO `sm_city` VALUES (482, 33, '望德堂区', 4);
INSERT INTO `sm_city` VALUES (483, 33, '风顺堂区', 5);
INSERT INTO `sm_city` VALUES (484, 33, '嘉模堂区', 6);
INSERT INTO `sm_city` VALUES (485, 33, '圣方济各堂区', 7);
INSERT INTO `sm_city` VALUES (486, 34, '台北市', 1);
INSERT INTO `sm_city` VALUES (487, 34, '高雄市', 2);
INSERT INTO `sm_city` VALUES (488, 34, '台中市', 3);
INSERT INTO `sm_city` VALUES (489, 34, '新竹市', 4);
INSERT INTO `sm_city` VALUES (490, 34, '基隆市', 5);
INSERT INTO `sm_city` VALUES (491, 34, '台南市', 6);
INSERT INTO `sm_city` VALUES (492, 34, '嘉义市', 7);

-- ----------------------------
-- Table structure for sm_department
-- ----------------------------
DROP TABLE IF EXISTS `sm_department`;
CREATE TABLE `sm_department`  (
  `id` int(0) NOT NULL AUTO_INCREMENT,
  `dept_name` varchar(80) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `short_name` varchar(80) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `projectid` int(0) NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 10 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of sm_department
-- ----------------------------
INSERT INTO `sm_department` VALUES (1, '信息科', '信息科', 1);
INSERT INTO `sm_department` VALUES (2, '供应室', '供应室', 1);
INSERT INTO `sm_department` VALUES (3, '手术室', '手术室', 1);
INSERT INTO `sm_department` VALUES (9, 'aa', 'aa', 1);

-- ----------------------------
-- Table structure for sm_employee
-- ----------------------------
DROP TABLE IF EXISTS `sm_employee`;
CREATE TABLE `sm_employee`  (
  `id` int(0) NOT NULL AUTO_INCREMENT,
  `employee_name` varchar(80) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `departmentid` int(0) NULL DEFAULT NULL,
  `cardno` varchar(80) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `duty` varchar(80) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `sex` varchar(80) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `cellphone` varchar(80) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `email` varchar(80) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for sm_message_log
-- ----------------------------
DROP TABLE IF EXISTS `sm_message_log`;
CREATE TABLE `sm_message_log`  (
  `id` int(0) NOT NULL AUTO_INCREMENT,
  `from_project_id` int(0) NULL DEFAULT NULL,
  `from_department_id` int(0) NULL DEFAULT NULL,
  `msg_type` varchar(80) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `msg_content` varchar(80) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for sm_project
-- ----------------------------
DROP TABLE IF EXISTS `sm_project`;
CREATE TABLE `sm_project`  (
  `id` int(0) NOT NULL AUTO_INCREMENT,
  `project_name` varchar(80) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `short_name` varchar(80) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `sign_date` datetime(0) NULL DEFAULT NULL,
  `address` varchar(80) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `phone` varchar(80) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `ProvinceId` int(0) NULL DEFAULT NULL,
  `cityid` int(0) NULL DEFAULT NULL,
  `current_progress` varchar(80) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `project_imple` varchar(80) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 25 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of sm_project
-- ----------------------------
INSERT INTO `sm_project` VALUES (1, '四川省人民中医院', '四川省中医', '2020-12-22 00:00:00', '成都市青羊区一环路西二段32号', '028-84301373', 24, 315, '实施', '彭万里');
INSERT INTO `sm_project` VALUES (2, '重庆医科大学附属第一医院', '重医附一', '2020-12-22 00:00:00', NULL, NULL, 27, 383, '待签', '黄强辉');
INSERT INTO `sm_project` VALUES (3, '涞源县人民医院', '涞源人民', '2020-12-22 00:00:00', NULL, 'aa', 24, 333, '待签', '章汉夫');
INSERT INTO `sm_project` VALUES (4, '云南省曲靖市第一人民医院（北城分院）', '曲靖市一', '2020-12-22 00:00:00', 'asdfas', NULL, 26, 350, '待签', '范长江');
INSERT INTO `sm_project` VALUES (5, '西藏昌都市人民医院', '西藏昌都', '2020-12-24 00:00:00', NULL, NULL, 28, 406, '待签', '林君雄');
INSERT INTO `sm_project` VALUES (6, '第三军医大学新桥医院', '新桥医院', '2020-12-24 00:00:00', '重庆市沙坪坝区新桥正街1号', '023-68755114(总机)', 27, 383, '实施', '朱希亮');
INSERT INTO `sm_project` VALUES (7, '北京朝阳医院京西院区', '京西院区', '2020-12-25 00:00:00', '北京市石景山区京原路5号', '010-85231000（总机）', 1, 9, '待签', NULL);
INSERT INTO `sm_project` VALUES (8, '中国医学科学院北京协和医院', '协和医院', '2020-12-25 00:00:00', '北京市 东城区 帅府园一号', '010-69156114', 1, 2, '待签', NULL);
INSERT INTO `sm_project` VALUES (9, '四川大学华西医院', '华西医院', '2020-12-25 00:00:00', '四川省 成都市 武侯区 国学巷37号', '028-85422114', 24, 315, '待签', NULL);
INSERT INTO `sm_project` VALUES (10, '上海交通大学医学院附属瑞金医院', '瑞金医院', '2020-12-23 00:00:00', '上海市 黄浦区 瑞金二路197号（永嘉路口）', '021-64370045', 16, 205, '待签', NULL);
INSERT INTO `sm_project` VALUES (11, '空军军医大学西京医院', '西京医院', '2020-12-25 00:00:00', '中国陕西省西安市', '029-84775507', 8, 91, '待签', NULL);
INSERT INTO `sm_project` VALUES (12, '复旦大学附属中山医院', '中山医院', '2020-12-22 00:00:00', '上海市 徐汇区 枫林路180号', '021-64041990', 16, 216, '待签', NULL);
INSERT INTO `sm_project` VALUES (13, '华中科技大学同济医学院附属同济医院', '同济医院', '2020-12-25 00:00:00', '湖北省 武汉市 江汉区 解放大道1095号', '027-83662688', 23, 298, '待签', NULL);
INSERT INTO `sm_project` VALUES (14, '浙江大学医学院附属第一医院', '浙江第一医院', '2020-12-23 00:00:00', '浙江省 杭州市 上城区 庆春路79号', '0571-87236114', 17, 220, '待签', NULL);
INSERT INTO `sm_project` VALUES (15, '陆军军医大学西南医院', '西南医院', '2020-12-25 00:00:00', '重庆市沙坪坝区高滩岩', ' 023-65318301', 27, 383, '待签', NULL);
INSERT INTO `sm_project` VALUES (16, '海军军医大学长海医院', '长海医院', '2020-12-23 00:00:00', '中国上海市', '021-31166666,31161111', 16, 199, '待签', NULL);
INSERT INTO `sm_project` VALUES (17, '中国医学科学院阜外医院 ', '阜外医院 ', '2020-12-25 00:00:00', '北京市 西城区 北礼士路167号', '010-68314466,88398866', 1, 10, '待签', NULL);
INSERT INTO `sm_project` VALUES (18, '北京大学第一医院', '第一医院', '2020-12-22 00:00:00', '北京市西城区西什库大街八号', '010-83572211(总机)', 1, 10, '待签', NULL);
INSERT INTO `sm_project` VALUES (19, '首都医科大学附属北京安贞医院', '北京安贞医院', '2020-12-25 00:00:00', '北京市朝阳区安贞路2号', '010-64456500(总机)', 1, 9, '待签', NULL);
INSERT INTO `sm_project` VALUES (20, '南方医科大学南方医院', '南方医院', '2020-12-25 00:00:00', '广东省广州市广州大道北1838号', '020-61641888', 29, 426, '待签', NULL);
INSERT INTO `sm_project` VALUES (21, '中国医科大学附属盛京医院', '盛京医院', '2020-12-25 00:00:00', '辽宁省沈阳市和平区三好街36号', '96615（客服电话）', 11, 134, '待签', NULL);
INSERT INTO `sm_project` VALUES (22, '广东省人民医院', '广东省人民医院', '2020-12-25 00:00:00', '广东省广州市中山二路106号', '020-83882222(预约中心)', 29, 426, '待签', NULL);
INSERT INTO `sm_project` VALUES (23, '中日友好医院', '中日友好医院', '2020-12-25 00:00:00', '北京市朝阳区樱花东街', '010-84205566(总机)', 1, 9, '待签', NULL);
INSERT INTO `sm_project` VALUES (24, '山东省立医院', '山东省立医院', '2020-12-25 00:00:00', '山东省济南市经五纬七路324号', '0531-87938911(总机)', 14, 169, '待签', NULL);

-- ----------------------------
-- Table structure for sm_province
-- ----------------------------
DROP TABLE IF EXISTS `sm_province`;
CREATE TABLE `sm_province`  (
  `id` int(0) NOT NULL AUTO_INCREMENT,
  `province_area` varchar(80) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `province_type` varchar(80) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `province_name` varchar(80) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 35 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of sm_province
-- ----------------------------
INSERT INTO `sm_province` VALUES (1, '华北地区', '直辖市', '北京市');
INSERT INTO `sm_province` VALUES (2, '华北地区', '直辖市', '天津市');
INSERT INTO `sm_province` VALUES (3, '华北地区', '省', '河北省');
INSERT INTO `sm_province` VALUES (4, '华北地区', '省', '山西省');
INSERT INTO `sm_province` VALUES (5, '华北地区', '省', '内蒙古自治区');
INSERT INTO `sm_province` VALUES (6, '西北地区', '自治区', '宁夏回族自治区');
INSERT INTO `sm_province` VALUES (7, '西北地区', '省', '青海省');
INSERT INTO `sm_province` VALUES (8, '西北地区', '省', '陕西省');
INSERT INTO `sm_province` VALUES (9, '西北地区', '省', '甘肃省');
INSERT INTO `sm_province` VALUES (10, '西北地区', '建设兵团', '新疆维吾尔自治区');
INSERT INTO `sm_province` VALUES (11, '东北地区', '省', '辽宁省');
INSERT INTO `sm_province` VALUES (12, '东北地区', '省', '吉林省');
INSERT INTO `sm_province` VALUES (13, '东北地区', '省', '黑龙江省');
INSERT INTO `sm_province` VALUES (14, '华东地区', '省', '山东省');
INSERT INTO `sm_province` VALUES (15, '华东地区', '省', '江苏省');
INSERT INTO `sm_province` VALUES (16, '华东地区', '直辖市', '上海市');
INSERT INTO `sm_province` VALUES (17, '华东地区', '省', '浙江省');
INSERT INTO `sm_province` VALUES (18, '华东地区', '省', '安徽省');
INSERT INTO `sm_province` VALUES (19, '华东地区', '省', '福建省');
INSERT INTO `sm_province` VALUES (20, '华东地区', '省', '江西省');
INSERT INTO `sm_province` VALUES (21, '华中地区', '省', '河南省');
INSERT INTO `sm_province` VALUES (22, '华中地区', '省', '湖南省');
INSERT INTO `sm_province` VALUES (23, '华中地区', '省', '湖北省');
INSERT INTO `sm_province` VALUES (24, '西南地区', '省', '四川省');
INSERT INTO `sm_province` VALUES (25, '西南地区', '省', '贵州省');
INSERT INTO `sm_province` VALUES (26, '西南地区', '省', '云南省');
INSERT INTO `sm_province` VALUES (27, '西南地区', '直辖市', '重庆市');
INSERT INTO `sm_province` VALUES (28, '西南地区', '自治区', '西藏自治区');
INSERT INTO `sm_province` VALUES (29, '华南地区', '省', '广东省');
INSERT INTO `sm_province` VALUES (30, '华南地区', '省', '广西省');
INSERT INTO `sm_province` VALUES (31, '华南地区', '省', '海南省');
INSERT INTO `sm_province` VALUES (32, '港澳台', '特别行政区', '香港特别行政区');
INSERT INTO `sm_province` VALUES (33, '港澳台', '特别行政区', '澳门特别行政区');
INSERT INTO `sm_province` VALUES (34, '港澳台', '省', '台湾省');

-- ----------------------------
-- Table structure for sm_right
-- ----------------------------
DROP TABLE IF EXISTS `sm_right`;
CREATE TABLE `sm_right`  (
  `id` int(0) NOT NULL AUTO_INCREMENT,
  `right_name` varchar(80) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `right_code` varchar(80) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `right_desc` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `show_index` int(0) NULL DEFAULT NULL,
  `right_type` varchar(80) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT 'right,role',
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for sm_role
-- ----------------------------
DROP TABLE IF EXISTS `sm_role`;
CREATE TABLE `sm_role`  (
  `id` int(0) NOT NULL AUTO_INCREMENT,
  `role_name` varchar(80) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `role_desc` varchar(80) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `show_index` int(0) NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for sm_role_right
-- ----------------------------
DROP TABLE IF EXISTS `sm_role_right`;
CREATE TABLE `sm_role_right`  (
  `id` int(0) NOT NULL AUTO_INCREMENT,
  `fk_role_id` int(0) NULL DEFAULT NULL,
  `fk_right_id` int(0) NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for sm_subscribe
-- ----------------------------
DROP TABLE IF EXISTS `sm_subscribe`;
CREATE TABLE `sm_subscribe`  (
  `id` int(0) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for sm_user
-- ----------------------------
DROP TABLE IF EXISTS `sm_user`;
CREATE TABLE `sm_user`  (
  `id` int(0) NOT NULL AUTO_INCREMENT,
  `user_account` varchar(80) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `user_type` varchar(80) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `projectid` int(0) NULL DEFAULT NULL,
  `departmentid` int(0) NULL DEFAULT NULL,
  `wx_unique_id` varchar(80) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `roleid` int(0) NULL DEFAULT NULL,
  `user_password` varchar(80) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `login_time` datetime(0) NULL DEFAULT NULL,
  `theme_url` varchar(80) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 4 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of sm_user
-- ----------------------------
INSERT INTO `sm_user` VALUES (1, 'aa', '管理员', -1, -1, NULL, NULL, '4124BC0A9335C27F086F24BA207A4912', '2021-01-08 18:00:26', '/images/1.jpg');
INSERT INTO `sm_user` VALUES (2, 'aa', '科室帐号', 1, 1, NULL, NULL, 'a1', NULL, NULL);
INSERT INTO `sm_user` VALUES (3, NULL, '科室帐号', 1, 1, NULL, NULL, NULL, NULL, NULL);

SET FOREIGN_KEY_CHECKS = 1;
