# Демонсет для добавления флагов kubelet.

## Описание 
Демонсет  будет выполнять следующее: 

1. При помощи bash скрипта постояннo проверять наличие нужных флагов на нодах.
2. В случае, если их нет, копировать их из конфигмапа.
3. Перезагружать kubelet.

Демонсет работает с нодами использующими Docker runtime. 

## Как запустить в общем случае

1) Создаем неймспейс для работы демонсета в целях изоляции его работы. 
```
kubectl apply -f kubelet-flag-editor-ns.yaml
```
1) Создаем простой конфигмап, с флагами внутри и не забываем кавычки в конце. 
```
kubectl apply -f kubelet-flag-editor-configmap --namespace="kubelet-flag-editor"
```

Далее переходим к созданию самого демонсета. 
1) Создаем демонсет

```
kubectl apply -f  kubelet-flag-editor-ds.yaml
```
Далее можно мониторить состояние демонсета, в случае, когда произойдет обновление флагов, то под перезагрузит процесс kubelet и новые флаги появятся на процессе kubelet.


### Обновление флагов.

При помощи: 

```kubectl edit configmap kubelet-flag-editor-configmap -o yaml -n kubelet-flag-editor```

Мы можем добавить дополнительные флаги, когда они понадобятся, однако стоит обратить внимание, что в скрипте проверки наличия флагов скорее проверяются сами флаги, а не их значения, поэтому если вы будете изменять значения, скрипт может подумать, что изменений быть не должно и пропустит изменения, в случае, если значения будут подобраны неверно (например, в конфигмапе выше перепутать gc-image-threshold high с low ), процесс kubelet не сможет перезапуститься и нода перейдет в статус not ready. 