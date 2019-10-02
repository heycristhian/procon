INSERT INTO `login` (`id`, `usuario`, `senha`) VALUES
(1, 'admin', 'admin');


INSERT INTO `alteracaoatendimento` (`id`, `numeroAtendimento`, `dataAlteracao`, `atendimentoID`) VALUES
(1, '003-2019-admin', '2019-09-26 17:12:59', 3),
(2, '010-2019-admin', '2019-09-26 14:32:45', 11),
(3, '006-2019-admin', '2019-09-26 14:38:06', 7),
(4, '007-2019-admin', '2019-09-26 14:39:43', 3),
(5, '001-2019-admin', '2019-09-26 14:39:53', 3),
(6, '014-2019-admin', '2019-09-26 14:41:26', 15),
(7, '002-2019-admin', '2019-10-02 15:21:10', 2),
(8, '001-2019-admin', '2019-10-02 16:01:56', 1),
(9, '001-2019-admin', '2019-10-02 16:03:40', 1),
(10, '001-2019-admin', '2019-10-02 16:06:25', 1),
(11, '002-2019-admin', '2019-10-02 16:06:37', 2),
(12, '001-2019-admin', '2019-10-02 16:10:21', 1),
(13, '002-2019-admin', '2019-10-02 16:10:31', 2),
(14, '008-2019-admin', '2019-10-02 16:10:35', 9);


INSERT INTO `atendimento` (`id`, `numeroProcon`, `reclamacao`, `dataInicio`, `dataEncerramento`, `usuario`, `consumidorID`, `fornecedorID`, `tipoAtendimentoID`, `tipoReclamacaoID`, `problemaPrincipalID`, `tipoStatus`, `TipoStatus_id`) VALUES
(1, '001/19', 'Consumidor alega que o fornecedor shoptime demorou muito tempo para entregar o produto e quando chegou acabou vindo errado e com uma burocracia enorme para fazer a devolução', '2019-10-01 00:00:00', '2019-10-02 16:10:21', NULL, 1, 1, 3, 3, 1, 0, NULL),
(2, '002/19', 'kdnjsjdnjasdjna idnjasdnsandasndmoma', '2019-09-19 00:00:00', '2019-10-02 16:10:31', NULL, 2, 1, 3, 3, 1, 0, NULL),
(3, '003-2019-admin', '', '2019-09-23 00:00:00', '2019-09-26 17:12:59', NULL, 2, 1, 2, 3, 1, 0, NULL),
(4, '004-2019-admin', 'O consumidor não tem a mínima condição de pagar a multa', '2019-09-24 00:00:00', '2019-09-26 17:11:38', NULL, 4, 3, 2, 8, 3, 0, NULL),
(5, '005-2019-admin', 'O consumidor teve problema na entrega, pois recebeu um produto que não era o que ele pediu', '2019-09-24 00:00:00', '2019-09-26 16:59:29', NULL, 5, 1, 2, 3, 1, 0, NULL),
(7, '006-2019-admin', '', '2019-09-26 00:00:00', '2019-09-26 14:38:06', NULL, 2, 1, 2, 3, 1, 0, NULL),
(8, '007-2019-admin', '', '2019-09-26 00:00:00', '2019-09-26 14:39:43', NULL, 2, 3, 2, 5, 2, 0, NULL),
(9, '003/19', '', '2019-09-26 00:00:00', '2019-10-02 16:10:35', NULL, 2, 3, 3, 5, 2, 0, NULL),
(10, '009-2019-admin', '', '2019-09-26 00:00:00', NULL, 'admin', 2, 3, 2, 5, 2, 0, NULL),
(11, '010-2019-admin', '', '2019-09-26 00:00:00', '2019-09-26 14:32:45', NULL, 2, 3, 2, 5, 2, 0, NULL),
(12, '011-2019-admin', '', '2019-09-26 00:00:00', '2019-09-26 14:40:42', NULL, 2, 3, 2, 5, 2, 0, NULL),
(13, '012-2019-admin', '', '2019-09-26 00:00:00', NULL, 'admin', 2, 1, 2, 3, 1, 0, NULL),
(14, '013-2019-admin', '', '2019-09-26 00:00:00', '2019-09-26 14:40:35', NULL, 2, 1, 2, 3, 1, 0, NULL),
(15, '014-2019-admin', '', '2019-09-26 00:00:00', '2019-09-26 14:41:26', NULL, 2, 1, 2, 3, 1, 0, NULL),
(16, '015-2019-admin', '', '2019-09-26 00:00:00', NULL, 'admin', 4, 3, 2, 5, 2, 0, NULL),
(17, '016-2019-admin', '', '2019-09-26 00:00:00', NULL, 'admin', 4, 3, 2, 5, 2, 0, NULL),
(18, '017-2019-admin', '', '2019-10-02 00:00:00', NULL, 'admin', 2, 3, 2, 5, 2, 0, NULL);


INSERT INTO `cidade` (`id`, `descricao`, `uf`) VALUES
(1, 'Assis', 'SP'),
(2, 'Candido Mota', 'SP');



INSERT INTO `consumidor` (`id`, `nome`, `endereco`, `bairro`, `cidadeID`, `cep`, `fone`, `foneComercial`, `celular`, `orgaoEmissor`, `email`, `rg`, `cpf`) VALUES
(1, 'Giseli Jaqueline', ',  ', '', 1, '', '', '', '', '', '', '', ''),
(2, 'Fulano de tal', ', ', '', 2, '', '', '', '', '', '', '', ''),
(4, 'Leonardo Brey', 'Não quis informar, ', 'Não quis informar', 1, '19840-000', '(18)3321-2081', '', '(18)99741-5398', 'SSP', 'leleobrey@gmail.com', '475722255', '084.858.439-24'),
(5, 'Luis', 'Rua José Conceição, 26', 'Conjunto Habitacional Nelson Marcondes', 2, '19813-515', '(18)3321-2081', '', '', '', 'heycristhian@gmail.com', '', '364.984.638-13');



INSERT INTO `fornecedor` (`id`, `razaoSocial`, `fantasia`, `contato`, `endereco`, `bairro`, `cidadeID`, `cep`, `fone`, `celular`, `whatsApp`, `email`, `site`, `cnpj`) VALUES
(1, 'SHOPTIME', 'SHOPTIME', '', '', '', 1, '', '', '', '', '', '', ''),
(2, 'Vivo', 'Vivo', '', '', '', 1, '', '', '', '', '', '', ''),
(3, 'Governo do Estado de São Paulo', '', '', '', '', 1, '', '', '', '', '', '', '');





INSERT INTO `problemaprincipal` (`id`, `descricao`, `tipoReclamacaoID`) VALUES
(1, 'Entrega de produto indevido', 3),
(2, 'Validade', 5),
(3, 'Multas indevidas', 8),
(4, 'Remédio deu alergia', 6);



INSERT INTO `tipoatendimento` (`id`, `descricao`) VALUES
(2, 'Atendimento'),
(3, 'CIP');


INSERT INTO `tiporeclamacao` (`id`, `descricao`) VALUES
(3, 'P - PRODUTO'),
(4, 'NFP - NOTA FISCAL PAULISTA'),
(5, 'A - ALIMENTOS'),
(6, 'S - SAÚDE'),
(8, 'SP - SERVIÇO PRIVADO'),
(9, 'SE - SERVIÇOS ESSENCIAIS'),
(10, 'AF - ASSUNTOS FINANCEIROS'),
(11, 'EP - EXTRA PROCON'),
(12, 'H - HABITAÇÃO');
