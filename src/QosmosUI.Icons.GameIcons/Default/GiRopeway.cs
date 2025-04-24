// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiRopeway : ComponentBase
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
		builder.AddAttribute(14, "d", "M304 20c-21.997 0-40 18.003-40 40 0 1.224.065 2.433.174 3.629a23.696 23.696 0 0 0-19.166 1.254C239.012 50.323 224.654 40 208 40c-21.997 0-40 18.003-40 40 0 19.307 13.87 35.534 32.135 39.215L16 170.363v16.608l232-64.446V200h16v-81.918l232-64.445V37.029L338.057 80.902A39.664 39.664 0 0 0 344 60c0-21.997-18.003-40-40-40zm0 16c13.35 0 24 10.65 24 24s-10.65 24-24 24-24-10.65-24-24 10.65-24 24-24zm-96 20c13.35 0 24 10.65 24 24s-10.65 24-24 24-24-10.65-24-24 10.65-24 24-24zm48 22.176c4.513 0 8 3.487 8 8s-3.487 8-8 8-8-3.487-8-8 3.487-8 8-8zm23.396 13.289a40.238 40.238 0 0 0 6.206 4.01L276.9 97.89a23.82 23.82 0 0 0 2.496-6.426zm-39.43 12.502a24.323 24.323 0 0 0 4.17 3.025l-9.269 2.574a40.53 40.53 0 0 0 5.1-5.6zM132.957 216L104 274.184V440h304V274.145L379.047 216H132.955zM136 240h64v96h-64v-96zm88 0h64v96h-64v-96zm88 0h64v96h-64v-96zM128 360h256v16H128v-16z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
