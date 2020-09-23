using System;
using UnityEngine;


[System.Serializable]
public class Sound //Clase creada para los sonidos
{
    public string name;
    public AudioClip clip;
    [Range(0f, 3f)]
    public float volume, pitch;
    public bool loop;
    [HideInInspector]
    public AudioSource source;
}

public class AudioManager : MonoBehaviour //Administra todos los sonidos del juego
{
    public static AudioManager instance;


    #region Sound files

    AudioClip gameMusic;
    AudioClip menuMusic;

    AudioClip startGame;

    AudioClip heroGotHit;
    AudioClip heroDash;
    AudioClip heroSlashAttack;
    AudioClip heroProjectile;


    AudioClip slimeGotHit;
    AudioClip slimeAttack;


    AudioSource music;
    AudioSource effects;

    #endregion


    void Awake()
    {
        if (instance == null) //Chequeamos que existe un único AudioManager
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
        InitSounds();
    }


    void InitSounds()
    {

        music = gameObject.AddComponent<AudioSource>();
        music.loop = true;
        effects = gameObject.AddComponent<AudioSource>();
        effects.loop = false;

        startGame = LoadEffectClip("StartGame");

        heroGotHit = LoadEffectClip("HeroGotHit");
        heroDash = LoadEffectClip("HeroDash");
        heroSlashAttack = LoadEffectClip("HeroSlashAttack");
        heroProjectile = LoadEffectClip("HeroProjectile");

        slimeGotHit = LoadEffectClip("SlimeGotHit");
        slimeAttack = LoadEffectClip("SlimeAttack");

        gameMusic = LoadMusicClip("GameMusic");
        menuMusic = LoadMusicClip("MenuMusic");
    }

    public void PlayMusic(AudioClip clip)
    {
        if (music.clip != clip)
        {
            music.Stop();
            music.clip = clip;
            music.Play();
        }
    }

    public void StopMusic()
    {
        music.Stop();
        music.clip = null;
    }

    public void PlayEffect(AudioClip clip)
    {
        effects.PlayOneShot(clip, effects.volume);
    }


    AudioClip LoadMusicClip(string filename)
    {
        AudioClip clip = Resources.Load<AudioClip>("Sounds/Music/" + filename);

        if (clip == null)
        {
            Debug.LogError(filename + " music clip not found");
            return null;
        }

        return clip;
    }

    AudioClip LoadEffectClip(string filename)
    {
        AudioClip clip = Resources.Load<AudioClip>("Sounds/SoundFX/" + filename);

        if (clip == null)
        {
            Debug.LogError(filename + " effect clip not found");
            return null;
        }

        return clip;
    }


    #region Event-triggered sounds

    public void StartGame()
    {
        PlayEffect(startGame);
    }
    public void HeroGotHit()
    {
        PlayEffect(heroGotHit);
    }
    public void HeroDash()
    {
        PlayEffect(heroDash);
    }
    public void HeroSlashAttack()
    {
        PlayEffect(heroSlashAttack);
    }
    public void HeroProjectile()
    {
        PlayEffect(heroProjectile);
    }
    public void EnemyGotHit(EnemyName enemyName)
    {
        switch (enemyName)
        {
            case EnemyName.Slime:
            {
                PlayEffect(slimeGotHit);
                    break;
            }
        }
    }
    public void EnemyAttack(EnemyName enemyName)
    {
        switch (enemyName)
        {
            case EnemyName.Slime:
                {
                    PlayEffect(slimeAttack);
                    break;
                }
        }
    }
    #endregion

    #region Play specific music
    public void GameMusic()
    {
        PlayMusic(gameMusic);
    }
    public void MenuMusic()
    {
        PlayMusic(menuMusic);
    }

    #endregion

    #region Change volumes

    public float MusicVolume
    {
        set { music.volume = Mathf.Clamp(value, 0, 1); print("music volume: " + music.volume); }
    }

    public float EffectsVolume
    {
        set
        {
            effects.volume = Mathf.Clamp(value, 0, 1);
        }
    }

    #endregion
}

