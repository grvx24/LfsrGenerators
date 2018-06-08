INSERT INTO Category (ID,CategoryName) values (0,'Generatory')
INSERT INTO Category (ID,CategoryName) values (1,'Szyfratory')
INSERT INTO Category (ID,CategoryName) values (2,'Funkcje Skrótu')
INSERT INTO Category (ID,CategoryName) values (3,'Podpisy Cyfrowe')

INSERT INTO Question (ID,Content,Time,CategoryId) values (0,'Ciąg generowany przez LFSR o n komórkach  pamięcu nazywa się maksymalnym, jeśli jego okres wynosi: ',20,0)
INSERT INTO Question (ID,Content,Time,CategoryId) values (1,'Które z poniższych generatorów wykorzystują zmienną liczbę rejestrów LSFR?',20,0)
INSERT INTO Question (ID,Content,Time,CategoryId) values (2,'Który z generatorów wykorzystuje trzy rejestry LFSR powiązane ze sobą nieliniowo przez multiplekser?',20,0)
INSERT INTO Question (ID,Content,Time,CategoryId) values (3,'Ile rejestrów LFSR wykorzystuje generator rozrzedzający?',20,0)
INSERT INTO Question (ID,Content,Time,CategoryId) values (4,'Do którego generatora pasuje poniższy opis? "Generator zbudowany z trzech rejestrów LSFR o różnej długości. LFSR-1 taktuje rejestr LFSR-2 jedynką, a rejestr LFSR-3 zerem. Ciąg wyjściowy jest sumą modulo 2 ciągów wyjściowych LSFR-2 i LFSR-3. "',20,0)
INSERT INTO Question (ID,Content,Time,CategoryId) values (5,'Generator samoobcinający jest odmianą genaratora rozrzedzającego (obcinającego), Zamiast dwóch rejestrów LFSR, stosuje parę bitów wyjściowych jednego rejestru LFSR. W porównaniu z generatorem rozrzedzającym generator samoobcinający... ',20,0)
INSERT INTO Question (ID,Content,Time,CategoryId) values (6,'Do którego generatora pasuje poniższy opis? "Generator wykorzystuje jeden rejestr LFSR i steruje własnym wyjściem zegarowym. Kiedy wyjście rejestru LFSR jest równe 0, wtedy ten LSFR jest taktowany d razy a gdy jest równe 1 to k razy,"',20,0)
INSERT INTO Question (ID,Content,Time,CategoryId) values (7,'Stan początkowy n bitów, z którego rejestr rozpoczyna pracę nazywamy:',20,0)


INSERT INTO Answer (ID,Content,Correct,QuestionId) values (1,'T=2^n-1',1,0)
INSERT INTO Answer (ID,Content,Correct,QuestionId) values (0,'T=2n-1',0,0)
INSERT INTO Answer (ID,Content,Correct,QuestionId) values (3,'T=1-2^n',0,0)
INSERT INTO Answer (ID,Content,Correct,QuestionId) values (2,'T=2^n+1',0,0)

INSERT INTO Answer (ID,Content,Correct,QuestionId) values (4,'Generator rozrzedzający',0,1)
INSERT INTO Answer (ID,Content,Correct,QuestionId) values (5,'Generator progowy',1,1)
INSERT INTO Answer (ID,Content,Correct,QuestionId) values (6,'Generator Geffego',0,1)
INSERT INTO Answer (ID,Content,Correct,QuestionId) values (7,'Kaskad. Gollmana',0,1)

INSERT INTO Answer (ID,Content,Correct,QuestionId) values (8,'Generator samodecymujący Rueppela',0,2)
INSERT INTO Answer (ID,Content,Correct,QuestionId) values (9,'Generator samoobcinający',0,2)
INSERT INTO Answer (ID,Content,Correct,QuestionId) values (10,'Generator progowy',0,2)
INSERT INTO Answer (ID,Content,Correct,QuestionId) values (11,'Generator Geffego',1,2)

INSERT INTO Answer (ID,Content,Correct,QuestionId) values (12,'dowolna liczba',0,3)
INSERT INTO Answer (ID,Content,Correct,QuestionId) values (13,'dwa',1,3)
INSERT INTO Answer (ID,Content,Correct,QuestionId) values (14,'trzy',0,3)
INSERT INTO Answer (ID,Content,Correct,QuestionId) values (15,'zmienna liczba (nieparzysta)',0,3)

INSERT INTO Answer (ID,Content,Correct,QuestionId) values (16,'Kaskada Gollmana',0,4)
INSERT INTO Answer (ID,Content,Correct,QuestionId) values (17,'Generator Geffego',0,4)
INSERT INTO Answer (ID,Content,Correct,QuestionId) values (18,'Generator rozrzedzający',0,4)
INSERT INTO Answer (ID,Content,Correct,QuestionId) values (19,'Generato przemienny stop-and-go',1,4)

INSERT INTO Answer (ID,Content,Correct,QuestionId) values (20,'jest wolnejszy, ale ma o połowę mniejsze wymagania pamięciowe',1,5)
INSERT INTO Answer (ID,Content,Correct,QuestionId) values (21,'jest szybszy, ale ma o połowę większe wymagania pamięciowe',0,5)
INSERT INTO Answer (ID,Content,Correct,QuestionId) values (22,'jest szybszy i ma mniejsze wymagania pamięciowe',0,5)
INSERT INTO Answer (ID,Content,Correct,QuestionId) values (23,'jest wolniejszy i ma większe wymagania pamięciowe',0,5)

INSERT INTO Answer (ID,Content,Correct,QuestionId) values (24,'Generator progowy',0,6)
INSERT INTO Answer (ID,Content,Correct,QuestionId) values (25,'Generator rozrzedzający',0,6)
INSERT INTO Answer (ID,Content,Correct,QuestionId) values (26,'Generator samoobcinający',0,6)
INSERT INTO Answer (ID,Content,Correct,QuestionId) values (27,'Generator samodecymujący Rueppela',1,6)

INSERT INTO Answer (ID,Content,Correct,QuestionId) values (28,'okruszkiem',0,7)
INSERT INTO Answer (ID,Content,Correct,QuestionId) values (29,'ziarnem',1,7)
INSERT INTO Answer (ID,Content,Correct,QuestionId) values (30,'szczyptą',0,7)
INSERT INTO Answer (ID,Content,Correct,QuestionId) values (31,'nasieniem',0,7)