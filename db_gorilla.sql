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

 Date: 23/12/2020 18:06:07
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
) ENGINE = InnoDB AUTO_INCREMENT = 4 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

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
  `fk_province_id` int(0) NULL DEFAULT NULL,
  `city_name` varchar(80) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `show_index` int(0) NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 38 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

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

-- ----------------------------
-- Table structure for sm_department
-- ----------------------------
DROP TABLE IF EXISTS `sm_department`;
CREATE TABLE `sm_department`  (
  `id` int(0) NOT NULL AUTO_INCREMENT,
  `dept_name` varchar(80) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `short_name` varchar(80) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `fk_project_id` int(0) NULL DEFAULT NULL,
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
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for sm_project
-- ----------------------------
DROP TABLE IF EXISTS `sm_project`;
CREATE TABLE `sm_project`  (
  `id` int(0) NOT NULL AUTO_INCREMENT,
  `project_name` varchar(80) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `short_name` varchar(80) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `sign_date` datetime(0) NULL DEFAULT NULL,
  `fk_province_id` int(0) NULL DEFAULT NULL,
  `fk_city_id` int(0) NULL DEFAULT NULL,
  `address` varchar(80) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `phone` varchar(80) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `cityid` int(0) NULL DEFAULT NULL,
  `ProvinceId` int(0) NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 3 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of sm_project
-- ----------------------------
INSERT INTO `sm_project` VALUES (1, 'ab', 'a', '2020-12-22 14:09:41', 1, 1, NULL, NULL, 1, 1);
INSERT INTO `sm_project` VALUES (2, 'aa', 'aa', '2020-12-22 14:09:41', 1, 1, NULL, NULL, 1, 2);
INSERT INTO `sm_project` VALUES (3, 'adsfasdfasdf', 'asdfasdf', '2020-12-22 14:09:41', 1, 2, NULL, NULL, 2, 3);
INSERT INTO `sm_project` VALUES (4, 'asdfasdf', 'asdfasdf', '2020-12-22 00:00:00', 1, 2, 'asdfas', 'dfasdf', 3, 4);

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
INSERT INTO `sm_province` VALUES (5, '华北地区', '省', '内蒙古');
INSERT INTO `sm_province` VALUES (6, '西北地区', '自治区', '宁夏回族自治区');
INSERT INTO `sm_province` VALUES (7, '西北地区', '省', '青海省');
INSERT INTO `sm_province` VALUES (8, '西北地区', '省', '陕西省');
INSERT INTO `sm_province` VALUES (9, '西北地区', '省', '甘肃省');
INSERT INTO `sm_province` VALUES (10, '西北地区', '建设兵团', '新疆建设兵团');
INSERT INTO `sm_province` VALUES (11, '东北地区', '省', '辽宁省');
INSERT INTO `sm_province` VALUES (12, '东北地区', '省', '吉林省');
INSERT INTO `sm_province` VALUES (13, '东北地区', '省', '黑龙江省');
INSERT INTO `sm_province` VALUES (14, '华东地区', NULL, '山东省');
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
-- Table structure for sm_user
-- ----------------------------
DROP TABLE IF EXISTS `sm_user`;
CREATE TABLE `sm_user`  (
  `id` int(0) NOT NULL AUTO_INCREMENT,
  `user_name` varchar(80) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `user_type` varchar(80) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `fk_project_id` int(0) NULL DEFAULT NULL,
  `fk_department_id` int(0) NULL DEFAULT NULL,
  `wx_unique_id` varchar(80) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `fk_role_id` int(0) NULL DEFAULT NULL,
  `user_pwd` varchar(80) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `login_time` datetime(0) NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

SET FOREIGN_KEY_CHECKS = 1;
