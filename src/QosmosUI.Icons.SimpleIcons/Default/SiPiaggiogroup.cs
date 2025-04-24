// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiPiaggiogroup : ComponentBase
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
		builder.AddAttribute(15, "d", "M17.657 21.15h-.42v-2.495h.42v2.494zm-9.79.001h-.42v-2.495l.582.03c.293-.015.58.082.794.27a.964.964 0 0 1 .337.72.63.63 0 0 1-.033.242c-.127.478-.6.806-1.13.781l-.13.002v.45zm0-.82h.264a.696.696 0 0 0 .543-.422.528.528 0 0 0 .064-.24c0-.449-.419-.661-.872-.63v1.291zm10.144-.413c0-.698.608-1.264 1.359-1.264s1.358.566 1.358 1.264c-.003.7-.604 1.271-1.357 1.29h-.003c-.754-.018-1.355-.59-1.357-1.29zm.45.003c-.002.471.4.858.907.871a.94.94 0 0 0 .651-.257.81.81 0 0 0 .255-.614c.017-.482-.388-.886-.906-.903-.513.028-.912.425-.906.903zm-1.74 1.228v-1.317h-.42v.93c-1.034.209-1.066-.752-1.066-.843 0-.57.612-1.085 1.486-.842v-.421c-1.65-.33-1.972.925-1.972 1.262 0 0-.163 1.622 1.972 1.231zm-6.786-1.231v-1.262h-.453v2.493h.453v-1.231zm4.46 1.231.008.004V19.83h-.388v.09l-.032.842c-1.035.209-1.067-.752-1.067-.843 0-.57.581-1.085 1.487-.842v-.421c-1.649-.33-2.004.925-1.971 1.262 0 0-.17 1.622 1.962 1.231zm-3.813 0h-.388l.486-1.231.484-1.262h.362l.478 1.262.484 1.231h-.453l-.194-.45h-1.065l-.194.45zm.355-.812h.808l-.163-.421-.224-.63-.258.63-.163.421zm.589-14.813v-.06C11.454 2.4 8.06 2.34 8.06 2.34H5.474v6.217h2.53s3.522.093 3.522-3.033zM22.801 0v21.227c.005.281-.043.561-.141.827-.274.7-.939 1.075-1.937 1.075h-7.42L12.035 24l-1.306-.871h-7.39a2.306 2.306 0 0 1-1.537-.54l-.06-.056a1.76 1.76 0 0 1-.402-.614 1.952 1.952 0 0 1-.142-.73V0h21.603zM2.923 16.312h3.004v-.09c-.454 0-.453-.572-.453-1.022V9.162s2.908.06 4.04.06c.64-.002 1.277-.063 1.905-.18 1.422-.337 3.071-1.203 3.102-3.516l.002-.06c0-3.485-4.202-3.756-4.202-3.756H2.923v.103c.225 0 .453.25.453 1.04v12.349c0 .45-.083.992-.453.992v.118zM22.312.46 2.104 22.22l.02.018c.33.286.766.44 1.216.43h7.55l1.142.763 1.116-.764h7.58c1.088 0 1.584-.458 1.584-1.444V.46z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
