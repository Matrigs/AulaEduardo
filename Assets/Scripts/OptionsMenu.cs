using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Audio;

public class OptionsMenu : MonoBehaviour
{
   //Resolução de Tela dentro de uma lista(array)
    Resolution[] resolutions;
   //Opções de Resolução
    public TMP_Dropdown dropdown;

    void Start()
    {
        //lista de resoluções dos Players = todas as resoluções detectadas
        resolutions = Screen.resolutions;

        //limpar as opções padrão do dropdown
        dropdown.ClearOptions();

        //Criar uma lista com todas as resoluções
        List<string> resOpcoes = new List<string>();
        
        int resAtual = 0;

        //enquanto os ciclos forem entre 0 o numero de resoluções
        for (int i = 0; i < resolutions.Length; i++)
        {
            //cria texto com a largura e a altura e adiciona na lista
            string option = resolutions[i].width + " X " + resolutions[i].height;

            //Adiciona o texto das opções na lista
            resOpcoes.Add(option);

            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)  
            {
                resAtual = i;
                
                
            }
        
        }
        dropdown.AddOptions(resOpcoes);
        dropdown.value = resAtual;
        dropdown.RefreshShownValue();

    }
    public void MudarResolucao(int resolucao)
    {
        //A resolução selecionada é igual a opção correspondente no array(item um da lista igual a 0 , item 2 igual a 1 ,...)
        Resolution select = resolutions[resolucao];

        //Mudar resolução
        Screen.SetResolution(select.width,select.height,Screen.fullScreen);
    }
    
    //Mudar Graficos de acordo com a posição de graficos na lista
    public void MudarGraficos(int grafico)
    {
        QualitySettings.SetQualityLevel(grafico);
    }

    //Aumentar para a tela completa
    public void TelaCheia(bool telacheia)
    {
        Screen.fullScreen = telacheia;
    }
    

}
