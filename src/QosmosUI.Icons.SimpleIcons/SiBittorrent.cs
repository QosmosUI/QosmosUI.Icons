// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiBittorrent : ComponentBase
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
		builder.AddAttribute(15, "d", "M12.0002.0014C5.3735.0004.001 5.3718 0 11.9984a11.9986 11.9986 0 0 0 1.7006 6.1593.132.132 0 0 0 .1128.0384c.0288 0 .048-.0696.048-.1104a.739.739 0 0 0-.0336-.1296 22.14 22.14 0 0 1-.4224-2.2941 9.8389 9.8389 0 0 1 .4272-3.866c1.1014-3.3956 3.3332-5.6993 6.664-6.9376a10.302 10.302 0 0 1 3.398-.5951.7823.7823 0 0 1 .8567.763c0 .4488-.3431.7368-.8495.7656a12.853 12.853 0 0 0-1.6078.1656 8.6918 8.6918 0 0 0-4.8642 2.6397C3.3468 10.8169 2.55 13.4566 3.03 16.4539a8.6846 8.6846 0 0 0 2.4454 4.785 8.9414 8.9414 0 0 0 6.3688 2.7597h.156a11.9507 11.9507 0 0 0 5.613-1.3918h-5.5938a8.3988 8.3988 0 0 1-1.4086-.1296c-4.1387-.7467-6.915-4.673-6.2393-8.8238.5627-3.5271 3.4722-6.2073 7.0336-6.4793a7.6407 7.6407 0 0 1 2.1597.1368.7487.7487 0 0 1 .6168.876.7847.7847 0 0 1-.96.6023 6.0836 6.0836 0 0 0-.8014-.1152 6.328 6.328 0 0 0-2.899.504c-2.5052 1.0803-4.0095 3.6719-3.705 6.3832.3566 3.1366 3.0056 5.5091 6.1624 5.5194h6.9904c.6791 0 .84.0144 1.1375-.24.382-.3525.742-.7284 1.0775-1.1255h-9.3302a4.3483 4.3483 0 0 1-2.0733-.516c-2.4037-1.1787-3.3968-4.0828-2.218-6.4865s4.0828-3.3968 6.4866-2.218c.1195.0586.2365.122.3508.1903a.7511.7511 0 0 1 .3168 1.044.7655.7655 0 0 1-1.0655.2711c-1.5988-.9125-3.6346-.356-4.547 1.2428a3.3332 3.3332 0 0 0-.3964 2.1792c.2433 1.6186 1.6388 2.8127 3.2756 2.8029 3.3596.0336 6.7193 0 10.0789 0a.4224.4224 0 0 0 .2807-.144c3.3584-5.7126 1.45-13.0661-4.2626-16.4245a11.9986 11.9986 0 0 0-6.0802-1.655z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
