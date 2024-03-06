// @ts-ignore
import {useRive} from '@rive-app/react-canvas';

import ClausHeroAnimation from './riv/claus.riv';

type ClausHeroProps = {
    className?: string;
};

export const ClausHero = ({className}: ClausHeroProps) => {
    const {RiveComponent} = useRive({
        src: ClausHeroAnimation,
        stateMachines: 'State Machine 1',
        autoplay: true,
    });

    return <RiveComponent className={className}/>;
};
