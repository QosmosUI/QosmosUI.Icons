// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiAirForce : ComponentBase
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
		builder.AddAttribute(14, "d", "M331.39 211.856c5.812 31.189-14.571 81.19-37.252 108.318-13.365 15.981-26.968 24.091-40.436 24.091h-.216c-12.728-.09-25.433-7.313-37.786-21.497-24.875-28.573-43.222-80.099-39.184-110.241l1.501-11.295 11.374-.114a77.073 77.073 0 0 0 55.041-23.624l9.441-9.76 9.44 9.76a77.016 77.016 0 0 0 55.246 23.636l10.84.068zm-173.54 6.301H16l18.78 18.825h124.094a116.019 116.019 0 0 1-1.024-18.813zm191.898 18.825H477.22L496 218.169H350.408a105.566 105.566 0 0 1-.66 18.813zm-187.246 18.825H53.604l18.813 18.824h95.818l-.102-.284a209.049 209.049 0 0 1-5.63-18.54zM340.24 274.63h99.344l18.825-18.824H346.154c-1.434 5.584-3.265 11.567-5.597 17.971zM91.242 293.445l18.824 18.824H185.9a203.602 203.602 0 0 1-9.93-18.824H91.242zm310.692 18.824l18.824-18.824h-88.55a211.69 211.69 0 0 1-10.236 18.824h79.962z");
		builder.AddAttribute(15, "class", "cls -2");
		builder.CloseElement();
		builder.CloseElement();
    }
}
