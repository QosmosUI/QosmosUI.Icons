// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiSergeant : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M255.978 39.21C226.38 86.89 161.383 164.77 106 203.713V256.6c53.113-38.92 105.113-92.538 140.56-145.71L256 96.735l9.44 14.157c35.333 53 87.963 106.298 140.56 145.473V203.77C349.61 164.835 285.346 86.825 255.978 39.21zm0 108.406C226.38 195.293 161.383 273.174 106 312.116v52.89C159.113 326.09 211.113 272.47 246.56 219.3l9.44-14.16 9.44 14.16c35.333 53 87.963 106.298 140.56 145.473v-52.597c-56.39-38.937-120.654-116.944-150.022-164.557zm0 107.782C226.38 303.075 161.383 380.956 106 419.898v52.89c53.113-38.918 105.113-92.536 140.56-145.707l9.44-14.16 9.44 14.16c35.333 53 87.963 106.298 140.56 145.473v-52.597c-56.39-38.938-120.654-116.945-150.022-164.558z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
