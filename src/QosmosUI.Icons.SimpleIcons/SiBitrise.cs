// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiBitrise : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "1em";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "currentColor";

    [Parameter]
    public string StrokeWidth { get; set; } = "0";

    [Parameter]
    public string StrokeLinecap { get; set; } = "round";

    [Parameter]
    public string StrokeLinejoin { get; set; } = "round";

    [Parameter]
    public string ViewBox { get; set; } = "0 0 24 24";

    [Parameter(CaptureUnmatchedValues = true)]
    public IReadOnlyDictionary<string, object>? AdditionalAttributes { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder.OpenElement(0, "svg");
        builder.AddAttribute(1, "xmlns", "http://www.w3.org/2000/svg");
        builder.AddAttribute(2, "viewBox", ViewBox);
        builder.AddAttribute(3, "width", Size);
        builder.AddAttribute(4, "height", Size);
        builder.AddAttribute(5, "fill", Fill);
        builder.AddAttribute(6, "stroke", Stroke);
        builder.AddAttribute(7, "stroke-width", StrokeWidth);
        builder.AddAttribute(8, "stroke-linecap", StrokeLinecap);
        builder.AddAttribute(9, "stroke-linejoin", StrokeLinejoin);
        builder.AddMultipleAttributes(10, AdditionalAttributes);
        if (!string.IsNullOrEmpty(Title))
        {
            builder.OpenElement(11, "title");
            builder.AddContent(12, Title);
            builder.CloseElement();
        }
		builder.OpenElement(13, "title");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M23.5154 13.4558c-.2744-1.8854-.692-3.7828-.9904-5.0477-.358-1.5035-1.6349-2.5775-3.1742-2.673-1.5155-.0955-4.0215-.2028-7.3627-.2028-3.3413 0-5.8472.1074-7.3627.2028-1.5394.0955-2.8163 1.1695-3.1743 2.673-.2983 1.265-.716 3.1623-.9904 5.0477-.191 1.2769-.3341 2.7685-.4535 4.463-.0596.9427.2506 1.8496.8831 2.5537.6324.704 1.4916 1.1217 2.4463 1.1575 2.0763.0955 5.2625.2148 8.6634.2148 3.401 0 6.587-.1193 8.6634-.2148.9427-.0477 1.8139-.4535 2.4463-1.1575.6325-.704.9427-1.611.883-2.5537-.1312-1.6945-.2863-3.198-.4773-4.463zm-1.6467 5.9188c-.3342.37-.7876.5848-1.2888.6086-2.0644.0955-5.2148.2148-8.5918.2148-3.3771 0-6.5274-.1193-8.5919-.2148-.5011-.0239-.9546-.2386-1.2887-.6086-.3342-.3699-.5012-.8472-.4654-1.3484.1074-1.6468.2506-3.1026.4415-4.3317.2625-1.8258.6683-3.6754.9666-4.9045.191-.7995.8592-1.3604 1.6826-1.42C6.2244 7.2745 8.6945 7.167 12 7.167c3.2935 0 5.7756.1074 7.2673.2029.8114.0477 1.4916.6205 1.6825 1.42.2864 1.2291.6921 3.0787.9666 4.9045.179 1.2291.3222 2.685.4415 4.3317 0 .5012-.167.9785-.4892 1.3484zM11.988 4.1958c.5608 0 1.0262-.4535 1.0262-1.0143 0-.561-.4534-1.0263-1.0262-1.0263-.5609 0-1.0263.4535-1.0263 1.0263 0 .5489.4654 1.0143 1.0263 1.0143zm5.9665 7.84c-.9069 0-1.6468.7399-1.6468 1.6468h3.2936c0-.907-.728-1.6468-1.6468-1.6468zm-11.933 0c-.907 0-1.6468.7399-1.6468 1.6468h3.2935c0-.907-.728-1.6468-1.6468-1.6468zm5.9665 5.9665c1.4677 0 2.661-1.1933 2.661-2.661h-5.334c0 1.4558 1.1933 2.661 2.673 2.661z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
