// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiFastify : ComponentBase
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
		builder.AddAttribute(15, "d", "M23.245 6.49L24 4.533l-.031-.121-7.473 1.967c.797-1.153.523-2.078.523-2.078s-2.387 1.524-4.193 1.485c-1.804-.04-2.387-.52-5.155.362-2.768.882-3.551 3.59-4.351 4.173-.804.583-3.32 2.477-3.32 2.477l.006.034 2.27-.724s-.622.585-1.945 2.37l-.062-.057.002.011s1.064 1.626 2.107 1.324a2.14 2.14 0 0 0 .353-.147c.419.234.967.463 1.572.525 0 0-.41-.475-.752-1.017l.238-.154.865.318-.096-.812c.003-.003.006-.003.008-.006l.849.311-.105-.738a5.65 5.65 0 0 1 .322-.158l.885-3.345 3.662-2.497-.291.733c-.741 1.826-2.135 2.256-2.135 2.256l-.582.22c-.433.512-.614.637-.764 2.353.348-.088.682-.107.984-.028 1.564.421 2.107 2.307 1.685 2.827-.104.13-.356.354-.673.617H7.77l-.008.514-.065.051h-.645l-.009.504-.17.127c-.607.011-1.373-.518-1.373-.518 0 .481.401 1.225.401 1.225l.07-.034-.061.045s1.625 1.083 2.646.681c.91-.356 3.263-2.213 5.296-3.093l6.15-1.62.811-2.1-4.688 1.235v-1.889l5.5-1.448.811-2.1-6.31 1.662V8.367zm-11.163 4l1.459-.384.02.074-.455 1.179-1.513.398zm.503 2.526l-1.512.398.489-1.266 1.459-.385.02.074zm1.971-.424l-1.513.398.49-1.266 1.459-.385.02.073Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
