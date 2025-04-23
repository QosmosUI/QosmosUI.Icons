// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiMinds : ComponentBase
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
		builder.AddAttribute(15, "d", "M15.496 18.381a.052.052 0 0 0 .03-.033l.693-2.217 3.192-4.791a.052.052 0 0 0 .003-.004.052.052 0 0 0 .001-.002.052.052 0 0 0 .001-.002.052.052 0 0 0 .002-.005.052.052 0 0 0 0-.003.052.052 0 0 0 .002-.003.052.052 0 0 0 0-.004.052.052 0 0 0 0-.005.052.052 0 0 0 0-.003.052.052 0 0 0 0-.003l-.416-6.947a.052.052 0 0 0 0-.001.052.052 0 0 0 0-.005.052.052 0 0 0 0-.002.052.052 0 0 0-.004-.008.052.052 0 0 0-.002-.005.052.052 0 0 0-.002-.004.052.052 0 0 0-.003-.005.052.052 0 0 0-.003-.003.052.052 0 0 0 0-.001L14.818.016V.014a.052.052 0 0 0-.005-.003.052.052 0 0 0-.003-.002.052.052 0 0 0-.003-.002.052.052 0 0 0-.002-.001.052.052 0 0 0-.002-.001.052.052 0 0 0-.002-.001.052.052 0 0 0 0-.001.052.052 0 0 0-.003 0 .052.052 0 0 0-.002-.001A.052.052 0 0 0 14.79 0a.052.052 0 0 0-.004 0 .052.052 0 0 0-.002 0 .052.052 0 0 0-.002 0 .052.052 0 0 0-.003 0 .052.052 0 0 0-.002 0H9.22a.052.052 0 0 0-.003 0 .052.052 0 0 0-.004 0 .052.052 0 0 0-.004 0 .052.052 0 0 0-.003.001.052.052 0 0 0-.003.001.052.052 0 0 0-.005.002.052.052 0 0 0-.004.003.052.052 0 0 0-.004.002.052.052 0 0 0-.001 0 .052.052 0 0 0-.003.004.052.052 0 0 0-.001 0 .052.052 0 0 0-.003.003L5.01 4.326a.052.052 0 0 0-.003.005.052.052 0 0 0-.006.009.052.052 0 0 0-.002.005.052.052 0 0 0-.002.008.052.052 0 0 0 0 .002.052.052 0 0 0-.001.003.052.052 0 0 0 0 .003l-.417 6.95a.052.052 0 0 0 0 .002.052.052 0 0 0 0 .005.052.052 0 0 0 0 .004.052.052 0 0 0 0 .002.052.052 0 0 0 0 .005.052.052 0 0 0 0 .003.052.052 0 0 0 .002.002.052.052 0 0 0 0 .002.052.052 0 0 0 .002.002.052.052 0 0 0 .003.004.052.052 0 0 0 0 .003l3.195 4.79.692 2.215v.002a.052.052 0 0 0 0 .001.052.052 0 0 0 .001.002.052.052 0 0 0 .002.003.052.052 0 0 0 0 .001.052.052 0 0 0 .001.002.052.052 0 0 0 0 .001.052.052 0 0 0 .002.001.052.052 0 0 0 .001.003.052.052 0 0 0 .001.001.052.052 0 0 0 .001.001.052.052 0 0 0 .002.002.052.052 0 0 0 .003.004.052.052 0 0 0 .002.001.052.052 0 0 0 .002.002.052.052 0 0 0 .001 0 .052.052 0 0 0 .003.003.052.052 0 0 0 .001 0 .052.052 0 0 0 .002.001.052.052 0 0 0 .002.002.052.052 0 0 0 .001 0 .052.052 0 0 0 .001 0 .052.052 0 0 0 .001.001.052.052 0 0 0 .002 0 .052.052 0 0 0 .001.001.052.052 0 0 0 .001 0 .052.052 0 0 0 .003.001.052.052 0 0 0 .002 0 .052.052 0 0 0 0 .001.052.052 0 0 0 .003 0 .052.052 0 0 0 .002 0 .052.052 0 0 0 .003.001.052.052 0 0 0 .001 0 .052.052 0 0 0 .002 0h6.954a.052.052 0 0 0 .02-.004zm-.058-.1H8.889l7.203-2.095zm.618-2.193L8.619 18.25l2.704-5.678zm.068-.08L11.39 12.49l5.14-4.125zm.11-.087l.4-7.542 2.668 2.937zm-7.7 2.27l-.647-2.07 3.232-3.36zm-.698-2.166l-3.094-4.641 6.457 1.143zm11.472-4.858l-2.655-2.92 2.256-3.718zm-7.975 1.236L9.3 5.283l7.188 2.983zm-.102.024l-6.508-1.152 4.475-5.966zm5.285-4.26L9.315 5.175 14.748.15zm.095-.053L14.87.217l4.015 4.15zM4.693 11.14l.403-6.72 4.03.807zm4.474-6.011l-4.015-.803L9.167.178zm.104-.056V.1h5.376zm-.748 13.36v4.143l1.672-1.403zm.057 4.232l1.53.612 1.81.723-1.67-2.737zM12.081 24l3.339-1.335-1.67-1.402zm3.395-1.424v-4.144l-1.67 2.74zm-6.86-4.192L12 23.932l3.383-5.548z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
