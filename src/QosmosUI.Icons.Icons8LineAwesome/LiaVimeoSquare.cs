// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaVimeoSquare : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 32 32";

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
		builder.AddAttribute(14, "d", "M 5 5 L 5 27 L 27 27 L 27 5 L 5 5 z M 7 7 L 25 7 L 25 25 L 7 25 L 7 7 z M 20.878906 10 C 18.970906 10 17.676 10.827922 17 13.044922 C 17.844 12.682922 19.091313 12.588 18.945312 14 C 18.906312 14.478 18.48325 15.358484 17.90625 16.271484 C 16.30425 18.798484 15.91425 17.954 15.03125 12.375 C 14.78125 10.804 14.122781 10.072781 13.050781 10.175781 C 12.103781 10.261781 10.588 11.769063 9 13.164062 L 9.6464844 14 C 10.262484 13.565 10.622563 13.390625 10.726562 13.390625 C 11.622563 13.390625 12.082969 15.719359 13.167969 19.693359 C 13.722969 21.174359 14.398125 21.914062 15.203125 21.914062 C 16.499125 21.914062 18.084031 20.696672 19.957031 18.263672 C 21.769031 15.934672 22.811094 14.096813 22.871094 12.757812 C 22.922094 11.047813 22.192906 10 20.878906 10 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
